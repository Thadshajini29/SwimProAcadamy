using System.Configuration;
using MySql.Data.MySqlClient;

public static class DatabaseHelper
{
    public static MySqlConnection GetConnection()
    {
        ConnectionStringSettings? settings = ConfigurationManager.ConnectionStrings["SwimProConnection"];
        if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
        {
            throw new InvalidOperationException(
                "The SwimProConnection connection string is missing from App.config.");
        }

        string connectionString = settings.ConnectionString;
        return new MySqlConnection(connectionString);
    }
}
