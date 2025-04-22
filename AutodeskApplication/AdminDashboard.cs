using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using AutodeskApplication.Utilities; // ✅ Needed for UserSessionHelper

namespace AutodeskApplication
{
    public partial class AdminDashboard : Form
    {
        private string adminEmail;
        private string userRole;
        private string adminTag; // ✅ Add tag field

        public AdminDashboard(string role, string email)
        {
            InitializeComponent();
            userRole = role;
            adminEmail = email;
            adminTag = FetchUserTag(email); // ✅ Fetch tag on load
            this.Text = "Admin Dashboard";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            string firstName = GetAdminFirstNameFromDatabase(adminEmail);
            lblWelcome.Text = $"Welcome, {firstName}!";

            AdminWelcomeControl welcomeControl = new AdminWelcomeControl(adminEmail);
            welcomeControl.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(welcomeControl);
        }

        private string GetAdminFirstNameFromDatabase(string email)
        {
            string firstName = "Admin";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT first_name FROM users WHERE email = @Email LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            firstName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching admin name:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return firstName;
        }

        private string FetchUserTag(string email)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT user_tag FROM users WHERE email = @Email LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Unknown";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve admin tag.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Unknown";
            }
        }

        private void btnViewAssets_Click(object sender, EventArgs e)
        {
            LoadControl(new AdminAssetControl(adminEmail, userRole));
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadControl(new ManageUsersControl());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // ✅ Log logout using UserSessionHelper
            UserSessionHelper.LogSession(adminTag, adminEmail, userRole, "Logout");

            this.Hide();
            new LoginForm().Show();
        }

        private void LoadControl(UserControl control)
        {
            pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(control);
        }
    }
}
