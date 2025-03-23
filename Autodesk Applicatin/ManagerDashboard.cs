using System;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class ManagerDashboard : Form
    {
        private string userRole;

        public ManagerDashboard(string role) // Accept role as a parameter
        {
            InitializeComponent();
            userRole = role;
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            // Ensure only admins or managers can access certain features
            if (userRole != "admin" && userRole != "manager")
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}