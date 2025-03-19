using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class LoginForm : Form
    {
        string connString = "Server=127.0.0.1;Port=3307;Database=AutodeskAssetsDB;User ID=root;Password=05032023Ak#;SslMode=None;AllowPublicKeyRetrieval=True;";



        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!ValidateInputs(email, password))
                return;

            bool loginSuccess = await AuthenticateUserAsync(email, password);

            if (loginSuccess)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT password_hash, CAST(role AS CHAR) FROM users WHERE email = @Email";

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
                                object hashObj = reader[0];  // Password hash (VARCHAR)
                                object roleObj = reader[1];  // Role (ENUM, returned as CHAR)

                                string storedHash = hashObj is DBNull ? "" : Convert.ToString(hashObj);
                                string userRole = roleObj is DBNull ? "viewer" : Convert.ToString(roleObj); // Default role: viewer


                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    RedirectUser(userRole);
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
                return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void RedirectUser(string role)
        {
            MainForm mainForm = new MainForm();
            Form dashboard = null;

            switch (role)
            {
                case "admin":
                    dashboard = new AdminDashboard();
                    break;
                case "editor":
                    dashboard = new EditorDashboard();
                    break;
                case "manager":
                    dashboard = new ManagerDashboard();
                    break;
                case "viewer":
                    dashboard = new ViewerDashboard();
                    break;
            }

            if (dashboard != null)
            {
                mainForm.LoadForm(dashboard);  // Load dashboard inside MainForm
                this.Hide();
                mainForm.Show();
            }
        }


        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signupForm = new Signup();
            signupForm.Show();
        }

        // UIHelper

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UIHelper.CenterTextVertically(txtEmail);
            UIHelper.CenterTextVertically(txtPassword);

        }

    }
}
