using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

public class UserDAL
{
    public bool HasAnyUsers()
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        using MySqlCommand command = new MySqlCommand("SELECT EXISTS(SELECT 1 FROM users)", connection);
        connection.Open();
        return Convert.ToInt32(command.ExecuteScalar()) == 1;
    }

    /// <summary>
    /// Creates a public account.  The first account in an empty system is the
    /// bootstrap administrator; later accounts require an administrator to
    /// assign a role and activate them.
    /// </summary>
    public bool RegisterPublicAccount(User user, string password)
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        connection.Open();

        // A MySQL named lock makes the empty-database check and insert atomic
        // even when two people register at the same time.
        bool lockTaken = false;
        try
        {
            using (MySqlCommand lockCommand = new MySqlCommand("SELECT GET_LOCK('swimpro:first-admin-registration', 10)", connection))
            {
                lockTaken = Convert.ToInt32(lockCommand.ExecuteScalar()) == 1;
            }

            if (!lockTaken)
                throw new InvalidOperationException("Registration is busy. Please try again in a moment.");

            using MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                bool isFirstAccount;
                using (MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(*) FROM users", connection, transaction))
                {
                    isFirstAccount = Convert.ToInt32(countCommand.ExecuteScalar()) == 0;
                }

                int userId;
                using (MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO users (full_name, username, email, password, is_active) " +
                    "VALUES (@fullName, @username, @email, @passwordHash, @isActive); SELECT LAST_INSERT_ID();", connection, transaction))
                {
                    insertCommand.Parameters.AddWithValue("@fullName", user.FullName.Trim());
                    insertCommand.Parameters.AddWithValue("@username", user.Username.Trim());
                    insertCommand.Parameters.AddWithValue("@email", user.Email.Trim());
                    insertCommand.Parameters.AddWithValue("@passwordHash", PasswordHelper.HashPassword(password));
                    insertCommand.Parameters.AddWithValue("@isActive", isFirstAccount ? 1 : 0);
                    userId = Convert.ToInt32(insertCommand.ExecuteScalar());
                }

                if (isFirstAccount)
                {
                    using MySqlCommand roleCommand = new MySqlCommand(
                        "INSERT INTO user_roles (user_id, role_id) SELECT @userId, id FROM roles WHERE role_name = 'Admin'", connection, transaction);
                    roleCommand.Parameters.AddWithValue("@userId", userId);
                    if (roleCommand.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("The Admin role is missing. Run the database setup script before registering.");
                }

                transaction.Commit();
                return isFirstAccount;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        finally
        {
            if (lockTaken)
            {
                using MySqlCommand releaseCommand = new MySqlCommand("DO RELEASE_LOCK('swimpro:first-admin-registration')", connection);
                releaseCommand.ExecuteNonQuery();
            }
        }
    }

    public bool UsernameOrEmailExists(string username, string email, int excludeUserId = 0)
    {
        using (MySqlConnection connection = DatabaseHelper.GetConnection())
        using (MySqlCommand command = new MySqlCommand(
            "SELECT COUNT(*) FROM users WHERE (username = @username OR email = @email) AND id <> @excludeUserId", connection))
        {
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@excludeUserId", excludeUserId);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }
    }

    public DataTable GetAllUsers()
    {
        DataTable table = new DataTable();
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        using MySqlCommand command = new MySqlCommand(@"SELECT u.id AS ID, u.full_name AS `Full Name`,
            u.username AS Username, u.email AS Email, r.role_name AS Role,
            IF(u.is_active = 1, 'Active', 'Inactive') AS Status
            FROM users u LEFT JOIN user_roles ur ON u.id = ur.user_id
            LEFT JOIN roles r ON ur.role_id = r.id ORDER BY u.id", connection);
        using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        adapter.Fill(table);
        return table;
    }

    public DataTable GetRoles()
    {
        DataTable table = new DataTable();
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        using MySqlCommand command = new MySqlCommand("SELECT role_name FROM roles ORDER BY id", connection);
        using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        adapter.Fill(table);
        return table;
    }

    public void AddUser(User user, string password, string roleName) => Register(user, password, roleName);

    public bool UpdateUser(User user, string roleName)
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        connection.Open();
        using MySqlTransaction transaction = connection.BeginTransaction();
        try
        {
            if ((!string.Equals(roleName, "Admin", StringComparison.OrdinalIgnoreCase) || !user.IsActive) &&
                IsActiveAdmin(connection, transaction, user.UserId) && CountActiveAdmins(connection, transaction) <= 1)
            {
                throw new InvalidOperationException("The last active Administrator cannot be deactivated or reassigned.");
            }

            using (MySqlCommand command = new MySqlCommand("UPDATE users SET full_name=@fullName, username=@username, email=@email, is_active=@isActive WHERE id=@userId", connection, transaction))
            {
                command.Parameters.AddWithValue("@fullName", user.FullName.Trim()); command.Parameters.AddWithValue("@username", user.Username.Trim());
                command.Parameters.AddWithValue("@email", user.Email.Trim()); command.Parameters.AddWithValue("@isActive", user.IsActive ? 1 : 0); command.Parameters.AddWithValue("@userId", user.UserId);
                if (command.ExecuteNonQuery() != 1) { transaction.Rollback(); return false; }
            }
            using (MySqlCommand command = new MySqlCommand("DELETE FROM user_roles WHERE user_id=@userId", connection, transaction))
            {
                command.Parameters.AddWithValue("@userId", user.UserId);
                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand("INSERT INTO user_roles (user_id, role_id) SELECT @userId, id FROM roles WHERE role_name=@roleName", connection, transaction))
            {
                command.Parameters.AddWithValue("@userId", user.UserId);
                command.Parameters.AddWithValue("@roleName", roleName);
                if (command.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("The selected role no longer exists.");
            }
            transaction.Commit(); return true;
        }
        catch { transaction.Rollback(); throw; }
    }

    public bool DeleteUser(int userId)
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        connection.Open();
        using MySqlTransaction transaction = connection.BeginTransaction();
        try
        {
            if (IsActiveAdmin(connection, transaction, userId) && CountActiveAdmins(connection, transaction) <= 1)
                throw new InvalidOperationException("The last active Administrator cannot be deleted.");

            using MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id=@userId", connection, transaction);
            command.Parameters.AddWithValue("@userId", userId);
            bool deleted = command.ExecuteNonQuery() == 1;
            transaction.Commit();
            return deleted;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    public void Register(User user, string password, string roleName)
    {
        using (MySqlConnection connection = DatabaseHelper.GetConnection())
        {
            connection.Open();
            MySqlTransaction transaction = connection.BeginTransaction();

            try
            {
                int userId;
                using (MySqlCommand command = new MySqlCommand(
                    "INSERT INTO users (full_name, username, email, password, is_active) " +
                    "VALUES (@fullName, @username, @email, @passwordHash, @isActive); SELECT LAST_INSERT_ID();", connection, transaction))
                {
                    command.Parameters.AddWithValue("@fullName", user.FullName);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@passwordHash", PasswordHelper.HashPassword(password));
                    command.Parameters.AddWithValue("@isActive", user.IsActive ? 1 : 0);
                    userId = Convert.ToInt32(command.ExecuteScalar());
                }

                using (MySqlCommand command = new MySqlCommand(
                    "INSERT INTO user_roles (user_id, role_id) " +
                    "SELECT @userId, id FROM roles WHERE role_name = @roleName", connection, transaction))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@roleName", roleName);
                    if (command.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("The selected role no longer exists.");
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }

    public User? Login(string usernameOrEmail, string password)
    {
        using (MySqlConnection connection = DatabaseHelper.GetConnection())
        using (MySqlCommand command = new MySqlCommand(
            "SELECT u.id, u.full_name, u.username, u.email, u.is_active, r.role_name " +
            "FROM users u " +
            "INNER JOIN user_roles ur ON u.id = ur.user_id " +
            "INNER JOIN roles r ON ur.role_id = r.id " +
            "WHERE (u.username = @login OR u.email = @login) AND u.password = @passwordHash AND u.is_active = 1 " +
            "LIMIT 1", connection))
        {
            command.Parameters.AddWithValue("@login", usernameOrEmail);
            command.Parameters.AddWithValue("@passwordHash", PasswordHelper.HashPassword(password));
            connection.Open();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read()) return null;

                return new User
                {
                    UserId = Convert.ToInt32(reader["id"]),
                    FullName = reader["full_name"].ToString() ?? string.Empty,
                    Username = reader["username"].ToString() ?? string.Empty,
                    Email = reader["email"].ToString() ?? string.Empty,
                    IsActive = Convert.ToBoolean(reader["is_active"]),
                    RoleName = (reader["role_name"].ToString() ?? string.Empty).Trim()
                };
            }
        }
    }

    public bool ChangePassword(int userId, string newPassword)
    {
        using (MySqlConnection connection = DatabaseHelper.GetConnection())
        using (MySqlCommand command = new MySqlCommand(
            "UPDATE users SET password = @passwordHash WHERE id = @userId", connection))
        {
            command.Parameters.AddWithValue("@passwordHash", PasswordHelper.HashPassword(newPassword));
            command.Parameters.AddWithValue("@userId", userId);
            connection.Open();
            return command.ExecuteNonQuery() == 1;
        }
    }

    public DataTable GetPermissions(int userId)
    {
        DataTable table = new DataTable();
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        connection.Open();
        string permissionColumn;
        using (MySqlCommand columnCommand = new MySqlCommand(
            "SELECT COLUMN_NAME FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'permissions' " +
            "AND COLUMN_NAME IN ('permission_code', 'permission_name', 'permission', 'name') ORDER BY FIELD(COLUMN_NAME, 'permission_code', 'permission_name', 'permission', 'name') LIMIT 1", connection))
        {
            permissionColumn = Convert.ToString(columnCommand.ExecuteScalar()) ?? string.Empty;
        }
        if (string.IsNullOrEmpty(permissionColumn))
            throw new InvalidOperationException("The permissions table needs a permission_code, permission_name, permission, or name column.");

        using MySqlCommand command = new MySqlCommand($@"SELECT DISTINCT p.`{permissionColumn}` AS permission_name
            FROM permissions p INNER JOIN role_permissions rp ON p.id = rp.permission_id
            INNER JOIN user_roles ur ON rp.role_id = ur.role_id WHERE ur.user_id = @userId", connection);
        command.Parameters.AddWithValue("@userId", userId);
        using MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        adapter.Fill(table);
        return table;
    }

    private static bool IsActiveAdmin(MySqlConnection connection, MySqlTransaction transaction, int userId)
    {
        using MySqlCommand command = new MySqlCommand(@"SELECT EXISTS(
            SELECT 1 FROM users u
            INNER JOIN user_roles ur ON ur.user_id = u.id
            INNER JOIN roles r ON r.id = ur.role_id
            WHERE u.id = @userId AND u.is_active = 1 AND r.role_name = 'Admin')", connection, transaction);
        command.Parameters.AddWithValue("@userId", userId);
        return Convert.ToInt32(command.ExecuteScalar()) == 1;
    }

    private static int CountActiveAdmins(MySqlConnection connection, MySqlTransaction transaction)
    {
        using MySqlCommand command = new MySqlCommand(@"SELECT COUNT(*) FROM users u
            INNER JOIN user_roles ur ON ur.user_id = u.id
            INNER JOIN roles r ON r.id = ur.role_id
            WHERE u.is_active = 1 AND r.role_name = 'Admin'", connection, transaction);
        return Convert.ToInt32(command.ExecuteScalar());
    }
}
