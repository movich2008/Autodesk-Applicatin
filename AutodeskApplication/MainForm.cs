using System;
using System.Windows.Forms;

namespace AutodeskApplication
{
    public partial class MainForm : Form
    {
        private Form currentDashboard;

        // Constructor for Admin, Editor, Manager dashboards
        public MainForm(Form dashboard)
        {
            InitializeComponent();
            LoadForm(dashboard);
            this.Text = dashboard.Text;
        }

        //  Constructor for Viewer
        public MainForm(Control dashboardControl)
        {
            InitializeComponent();

            // Handle viewer-specific events
            if (dashboardControl is ViewerGalleryControl gallery)
            {
                gallery.OnAssetSelected += asset =>
                {
                    var viewerControl = new Viewer3DViewerControl(asset, gallery.ViewerEmail);
                    LoadForm(viewerControl);
                };

                gallery.OnLogoutClicked += () =>
                {
                    this.Hide();
                    new LoginForm().Show();
                };
            }

            // Load viewer dashboard
            LoadForm(dashboardControl);
        }

        // For loading Forms
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
            pnlMain.Controls.Add(currentDashboard);
            currentDashboard.Show();
        }

        // For loading UserControls
        public void LoadForm(Control dashboardControl)
        {
            pnlMain.Controls.Clear();
            dashboardControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(dashboardControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
        }
    }
}
