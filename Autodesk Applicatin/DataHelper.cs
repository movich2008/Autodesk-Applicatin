using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Autodesk_Application
{
    public class DataHelper
    {
        public static readonly string connection = "Data Source=autodesk.db;Version=3;New=False;Compress=True;";

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

        public static int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            int rowsAffected = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database error: " + ex.Message);
                }
            }
            return rowsAffected;
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

        // Get username from the database
        public  string GetUsername(string inputUsername)
        {
            string query = "SELECT Username FROM Users WHERE Username = @Username";
            object result = ExecuteScalar(query, new SQLiteParameter("@Username", inputUsername));
            return result?.ToString();
        }

        // Get password from the database
        public  string GetPassword(string inputUsername)
        {
            string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
            object result = ExecuteScalar(query, new SQLiteParameter("@Username", inputUsername));
            return result?.ToString();
        }

        // Validate if username and password match
        public  bool ValidateLogin(string inputUsername, string inputPassword)
        {
            string storedUsername = GetUsername(inputUsername);
            string storedPassword = GetPassword(inputUsername);

            return storedUsername != null && storedPassword == inputPassword;
        }
    }
}
