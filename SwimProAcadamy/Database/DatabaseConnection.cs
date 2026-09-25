using System.Configuration;
using MySql.Data.MySqlClient;

namespace SwimProAcadamy;

// Gets the MySQL connection string from App.config.
public static class DatabaseConnection
{
    public static MySqlConnection GetConnection()
    {
        string? connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString;

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("MyDbConnection is missing from App.config.");
        }

        return new MySqlConnection(connectionString);
    }
}
