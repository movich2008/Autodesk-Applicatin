using System;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class MainForm : Form
    {
        private Form currentDashboard;

        public MainForm(Form dashboard)
        {
            InitializeComponent();
            LoadForm(dashboard); // Load passed dashboard
            this.Text = dashboard.Text;
        }

        public void LoadForm(Form dashboard)
        {
            if (currentDashboard != null)
            {
                currentDashboard.Close();
                currentDashboard.Dispose();
            }

            currentDashboard = dashboard;
            currentDashboard.TopLevel = false;
            currentDashboard.FormBorderStyle = FormBorderStyle.None;
            currentDashboard.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(currentDashboard);
            currentDashboard.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
        }
    }

}