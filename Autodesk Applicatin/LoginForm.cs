using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class LoginForm : Form
    {
        //string connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;



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

                // Fetch the user role from the database
                string userRole = await GetUserRoleFromDatabase(email);

                Form dashboard = null;

                switch (userRole.ToLower())
                {
                    case "admin":
                        dashboard = new AdminDashboard(userRole);
                        break;
                    case "manager":
                        dashboard = new ManagerDashboard(userRole);
                        break;
                    case "editor":
                        dashboard = new EditorDashboard(userRole);
                        break;
                    case "viewer":
                        dashboard = new ViewerDashboard(userRole); // Viewer redirection
                        break;
                    default:
                        MessageBox.Show("Invalid role detected. Contact admin.");
                        return;
                }

                // Ensure only one MainForm is created
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

                if (mainForm == null)
                {
                    mainForm = new MainForm(dashboard); // Create MainForm with the correct dashboard
                    mainForm.Show();  // Show the MainForm
                }
                else
                {
                    mainForm.LoadForm(dashboard); // If MainForm already exists, load the dashboard
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async Task<string> GetUserRoleFromDatabase(string email)
        {
            string role = string.Empty;
          
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
                        {
                            role = result.ToString(); // Get the role from the database
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role; // Return the user's role
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
            Form dashboard = null;

            switch (role.ToLower()) // ✅ Ensure case-insensitivity
            {
                case "admin":
                    dashboard = new AdminDashboard(role);
                    break;
                case "editor":
                    dashboard = new EditorDashboard(role);
                    break;
                case "manager":
                    dashboard = new ManagerDashboard(role);
                    break;
                case "viewer":
                    dashboard = new ViewerDashboard(role);
                    break;
                default:
                    MessageBox.Show("Invalid role detected. Contact admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // ✅ Exit function if role is invalid
            }

            if (dashboard != null)
            {
                MainForm mainForm = new MainForm(dashboard); // ✅ Pass correct dashboard to MainForm
                this.Hide(); // ✅ Hide the login form
                mainForm.Show(); // ✅ Show MainForm with the dashboard inside pnlContainer
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
