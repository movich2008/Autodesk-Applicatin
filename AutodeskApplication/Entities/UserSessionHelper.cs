using MySql.Data.MySqlClient;

namespace AutodeskApplication.Utilities
{
    public static class UserSessionHelper
    {
        public static void LogSession(string tag, string email, string role, string activityType)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO UserActivity (UserTag, Email, Role, ActivityType) VALUES (@Tag, @Email, @Role, @Activity)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tag", tag);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Activity", activityType);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
