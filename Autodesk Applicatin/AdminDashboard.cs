using System;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class AdminDashboard : Form
    {
        private string userRole; // Store the logged-in user's role

        public AdminDashboard(string role)
        {
            InitializeComponent();
            userRole = role;
            this.Text = "Admin Dashboard"; // Set the form title
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {userRole}!"; // Display role-based welcome message
        }

        private void btnViewAssets_Click(object sender, EventArgs e)
        {
            LoadControl(new AssetsControl());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadControl(new ManageUsersControl());
        }

        private void LoadControl(UserControl control)
        {
            pnlMain.Controls.Clear(); // Remove previous content
            control.Dock = DockStyle.Fill; // Make it fill pnlMain
            pnlMain.Controls.Add(control); // Add the new control
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}