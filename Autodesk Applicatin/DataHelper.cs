using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace Autodesk_Applicatin
{
    internal static class DataHelper
    {
        public static readonly string connection = ""; //"Data Source=autodesk.db;Version=3;New=False;Compress=True;"//;

                private static DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
                {
                    DataTable dt = new DataTable();
                    using (SQLiteConnection conn = new SQLiteConnection(connection))
                    {
                        try
                        {
                            conn.Open();
                            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                            {
                                if (parameters != null) cmd.Parameters.AddRange(parameters);
                                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                                {
                                    adapter.Fill(dt);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Database error: " + ex.Message);
                        }
                    }
                        return dt;
                }
                public static object ExecuteScalar(string query, params SQLiteParameter[] parameters)
                {
                    object result = null;
                    using (SQLiteConnection conn = new SQLiteConnection(connection))
                    {
                        try
                        {
                            conn.Open();
                            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                            {
                                if (parameters != null) cmd.Parameters.AddRange(parameters);
                                result = cmd.ExecuteScalar();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Database error: " + ex.Message);
                        }
                    }
                    return result;
                }
    }

}

