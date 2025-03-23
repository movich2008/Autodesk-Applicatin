using System;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class MainForm : Form
    {
        public MainForm(Form dashboard)
        {
            InitializeComponent();
            LoadForm(dashboard); // Load the correct dashboard when MainForm opens

            this.Text = dashboard.Text;
        }

        public void LoadForm(Form dashboard)
        {
            this.Controls.Clear(); // Clear any existing content
            dashboard.TopLevel = false; // Make the dashboard act like a user control
            dashboard.FormBorderStyle = FormBorderStyle.None; // Remove window borders
            dashboard.Dock = DockStyle.Fill; // Fill the MainForm with the dashboard
            this.Controls.Add(dashboard); // Add the dashboard to the MainForm's controls
            dashboard.Show(); // Show the dashboard inside MainForm
        }
    }
}