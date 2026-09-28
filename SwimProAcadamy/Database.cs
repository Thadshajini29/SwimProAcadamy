using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SwimProAcadamy
{
    public class Database
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["SwimProConnection"].ConnectionString;

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
