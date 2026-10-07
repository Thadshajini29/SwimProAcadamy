using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.Models;

public class UserDAL
{
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
            using (MySqlCommand command = new MySqlCommand("UPDATE users SET full_name=@fullName, username=@username, email=@email, is_active=@isActive WHERE id=@userId", connection, transaction))
            {
                command.Parameters.AddWithValue("@fullName", user.FullName.Trim()); command.Parameters.AddWithValue("@username", user.Username.Trim());
                command.Parameters.AddWithValue("@email", user.Email.Trim()); command.Parameters.AddWithValue("@isActive", user.IsActive ? 1 : 0); command.Parameters.AddWithValue("@userId", user.UserId);
                if (command.ExecuteNonQuery() != 1) { transaction.Rollback(); return false; }
            }
            using (MySqlCommand command = new MySqlCommand("DELETE FROM user_roles WHERE user_id=@userId; INSERT INTO user_roles (user_id, role_id) SELECT @userId, id FROM roles WHERE role_name=@roleName", connection, transaction))
            {
                command.Parameters.AddWithValue("@userId", user.UserId); command.Parameters.AddWithValue("@roleName", roleName); command.ExecuteNonQuery();
            }
            transaction.Commit(); return true;
        }
        catch { transaction.Rollback(); throw; }
    }

    public bool DeleteUser(int userId)
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        using MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id=@userId", connection);
        command.Parameters.AddWithValue("@userId", userId); connection.Open(); return command.ExecuteNonQuery() == 1;
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
                    command.ExecuteNonQuery();
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

    // Public registration deliberately creates no user_roles record. An Admin
    // assigns the appropriate role later; the account may still sign in safely.
    public void RegisterPending(User user, string password)
    {
        using MySqlConnection connection = DatabaseHelper.GetConnection();
        using MySqlCommand command = new MySqlCommand(
            "INSERT INTO users (full_name, username, email, password, is_active) " +
            "VALUES (@fullName, @username, @email, @passwordHash, 1)", connection);

        command.Parameters.AddWithValue("@fullName", user.FullName.Trim());
        command.Parameters.AddWithValue("@username", user.Username.Trim());
        command.Parameters.AddWithValue("@email", user.Email.Trim());
        command.Parameters.AddWithValue("@passwordHash", PasswordHelper.HashPassword(password));
        connection.Open();
        command.ExecuteNonQuery();
    }

    public User? Login(string usernameOrEmail, string password)
    {
        using (MySqlConnection connection = DatabaseHelper.GetConnection())
        using (MySqlCommand command = new MySqlCommand(
            "SELECT u.id, u.full_name, u.username, u.email, u.is_active, r.role_name " +
            "FROM users u " +
            "LEFT JOIN user_roles ur ON u.id = ur.user_id " +
            "LEFT JOIN roles r ON ur.role_id = r.id " +
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
}
