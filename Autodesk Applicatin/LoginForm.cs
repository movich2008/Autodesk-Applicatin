using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Autodesk_Applicatin
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
            if (string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("User role not found. Please contact admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide(); // ✅ Hide the login form

            Form dashboard = CreateDashboard(userRole); // ✅ create dashboard once
            if (dashboard == null)
            {
                MessageBox.Show("Invalid role. Cannot continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm mainForm = new MainForm(dashboard); // ✅ Pass dashboard once
            mainForm.Show(); // ✅ This internally loads and shows it
        }



        private Form CreateDashboard(string role)
        {
            switch (role.ToLower())
            {
                case "admin": return new AdminDashboard(role);
                case "manager": return new ManagerDashboard(role);
                case "editor": return new EditorDashboard(role);
                case "viewer": return new ViewerDashboard(role);
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

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signupForm = new Signup();
            signupForm.Show();
        }
    }
}
