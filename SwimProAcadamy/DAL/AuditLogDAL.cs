using System;
using System.Data;
using MySql.Data.MySqlClient;
using SwimProAcadamy.DAL;

public static class AuditLogDAL
{
    public static void Log(string action, string module, string description)
    {
        try
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(
                "INSERT INTO audit_logs (user_id, action, module, description) " +
                "VALUES (@userId, @action, @module, @description)", connection))
            {
                command.Parameters.AddWithValue("@userId", UserSession.UserId == 0 ? DBNull.Value : UserSession.UserId);
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@module", module);
                command.Parameters.AddWithValue("@description", description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch
        {
            // Logging failure should not interrupt main application execution
        }
    }

    public static DataTable GetAuditLogs(string username = "", string action = "", DateTime? fromDate = null, DateTime? toDate = null)
    {
        DataTable table = new DataTable();
        try
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT a.id AS ID,
                                      COALESCE(u.username, 'System') AS Username,
                                      a.action AS Action,
                                      a.module AS Module,
                                      a.description AS Description,
                                      a.created_at AS `Date/Time`
                               FROM audit_logs a
                               LEFT JOIN users u ON a.user_id = u.id
                               WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(username))
                {
                    sql += " AND u.username LIKE @username";
                }
                if (!string.IsNullOrWhiteSpace(action) && action != "All Actions")
                {
                    sql += " AND a.action = @action";
                }
                if (fromDate.HasValue)
                {
                    sql += " AND a.created_at >= @fromDate";
                }
                if (toDate.HasValue)
                {
                    sql += " AND a.created_at <= @toDate";
                }

                sql += " ORDER BY a.created_at DESC";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    if (!string.IsNullOrWhiteSpace(username))
                        command.Parameters.AddWithValue("@username", "%" + username.Trim() + "%");
                    if (!string.IsNullOrWhiteSpace(action) && action != "All Actions")
                        command.Parameters.AddWithValue("@action", action);
                    if (fromDate.HasValue)
                        command.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
                    if (toDate.HasValue)
                        command.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1).AddSeconds(-1));

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Unable to fetch audit logs: " + ex.Message);
        }
        return table;
    }
}
