using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodesk_Applicatin
{
    public static class DatabaseHelper
    {
        private static string connString;

        static DatabaseHelper()
        {
            // Use MySqlConnectionStringBuilder to construct the connection string
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";  // Your MySQL server address
            builder.Port = 3307;           // Port
            builder.Database = "AutodeskAssetsDB"; // Your database name
            builder.UserID = "root";        // Your MySQL username
            builder.Password = "05032023Ak#";  // Your MySQL password
            builder.SslMode = MySqlSslMode.None;  // If you're not using SSL

            connString = builder.ConnectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}