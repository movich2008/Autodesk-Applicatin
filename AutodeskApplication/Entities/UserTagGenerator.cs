using System;
using System.Text;
using MySql.Data.MySqlClient;

namespace AutodeskApplication.Utilities
{
    public static class UserTagGenerator
    {
        public static string GenerateUserTag(string firstName, string lastName)
        {
            string initials = GetInitials(firstName, lastName);
            string tag;
            Random rnd = new Random();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                int attempts = 0;
                do
                {
                    int rand = rnd.Next(100, 999);
                    tag = $"{initials}{rand}";
                    string query = "SELECT COUNT(*) FROM users WHERE user_tag = @Tag";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tag", tag);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                            break;
                    }
                    attempts++;
                } while (attempts < 10);
            }

            return tag;
        }

        private static string GetInitials(string first, string last)
        {
            string f = string.IsNullOrEmpty(first) ? "X" : first[0].ToString().ToUpper();
            string l = string.IsNullOrEmpty(last) ? "X" : last[0].ToString().ToUpper();
            return f + l;
        }
    }
}