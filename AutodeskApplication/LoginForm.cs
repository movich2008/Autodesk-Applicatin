using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using AutodeskApplication.Utilities; // ✅ Required for UserSessionHelper

namespace AutodeskApplication
{
    public partial class LoginForm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!ValidateInputs(email, password)) return;

            bool loginSuccess = await AuthenticateUserAsync(email, password);
            if (!loginSuccess) return;

            string userRole = await GetUserRoleFromDatabase(email);
            string userTag = await GetUserTagFromDatabase(email);

            if (string.IsNullOrEmpty(userRole) || string.IsNullOrEmpty(userTag))
            {
                MessageBox.Show("Failed to retrieve user info. Please contact admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Log the login event using the centralized helper
            UserSessionHelper.LogSession(userTag, email, userRole, "Login");

            try
            {
                object dashboard = CreateDashboard(userRole, email);
                if (dashboard == null)
                {
                    MessageBox.Show("Invalid role. Cannot continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Hide();

                if (dashboard is Form form)
                {
                    form.Show();
                }
                else if (dashboard is Control control)
                {
                    new MainForm(control).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object CreateDashboard(string role, string email)
        {
            switch (role.ToLower())
            {
                case "admin": return new AdminDashboard(role, email);
                case "manager": return new ManagerDashboard(role, email);
                case "editor": return new EditorDashboard(role, email);
                case "viewer": return new ViewerGalleryControl(email);
                default: return null;
            }
        }

        private async Task<string> GetUserRoleFromDatabase(string email)
        {
            string role = "";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    await conn.OpenAsync();
                    string query = "SELECT role FROM users WHERE email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                            role = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role;
        }

        private async Task<string> GetUserTagFromDatabase(string email)
        {
            string tag = "";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    await conn.OpenAsync();
                    string query = "SELECT user_tag FROM users WHERE email = @Email LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                            tag = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve user tag.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tag;
        }

        private bool ValidateInputs(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task<bool> AuthenticateUserAsync(string email, string password)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    await conn.OpenAsync();
                    string query = "SELECT password_hash FROM users WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No user found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }

                            if (await reader.ReadAsync())
                            {
                                string storedHash = reader["password_hash"].ToString();
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UIHelper.CenterTextVertically(txtEmail);
            UIHelper.CenterTextVertically(txtPassword);
            UIStyleHelper.StyleAllControls(this);
        }

        private void linkSignup_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Signup signupForm = new Signup();
            signupForm.Show();
        }
    }
}
