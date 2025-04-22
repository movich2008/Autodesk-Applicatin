using MySql.Data.MySqlClient;
using System;

namespace AutodeskApplication
{
    public static class DatabaseHelper
    {
        private static string connString;

        static DatabaseHelper()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "gateway01.eu-central-1.prod.aws.tidbcloud.com";
            builder.Port = 4000;
            builder.Database = "autodeskassetsdb";
            builder.UserID = "47k4VMFYq5g1brU.root";
            builder.Password = "PErqrsK2ZGPB1tmU";
            builder.SslMode = MySqlSslMode.VerifyCA;
            builder.CertificateFile = "C:\\TiDB\\cert\\tidb-server-ca.pem"; 

            connString = builder.ConnectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}