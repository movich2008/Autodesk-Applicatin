using System;
using System.IO;
using System.Windows.Forms;
using HelixToolkit.Wpf;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Drawing;
using MySql.Data.MySqlClient;
using AutodeskApplication.Utilities; // ✅ Required for UserSessionHelper

namespace AutodeskApplication
{
    public partial class Viewer3DViewerControl : UserControl
    {
        private HelixViewport3D helixViewport;
        private AssetDetails asset;
        private string viewerEmail;
        private string viewerTag;

        public event Action OnLogoutClicked;
        public event Action OnBackClicked;

        public Viewer3DViewerControl(AssetDetails assetDetails, string email)
        {
            InitializeComponent();
            asset = assetDetails;
            viewerEmail = email;
            viewerTag = GetViewerTag(email);

            LogViewerActivity(); // ✅ Log view
            Setup3DViewer();
            DisplayAssetInfo();
        }

        private string GetViewerTag(string email)
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
                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Unknown";
                    }
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        private void Setup3DViewer()
        {
            helixViewport = new HelixViewport3D
            {
                Background = System.Windows.Media.Brushes.White,
                ZoomExtentsWhenLoaded = true,
                ShowCoordinateSystem = false,
                IsHeadLightEnabled = true,
                ShowCameraInfo = false,
                ShowViewCube = false
            };

            ElementHost host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = helixViewport
            };

            panel3D.Controls.Clear();
            panel3D.Controls.Add(host);

            if (File.Exists(asset.AssetFilePath))
            {
                var model = new ObjReader().Read(asset.AssetFilePath);
                helixViewport.Children.Add(new ModelVisual3D { Content = model });
                helixViewport.Children.Add(new DefaultLights());
                try { helixViewport.ZoomExtents(); } catch { }
            }
            else
            {
                MessageBox.Show("3D model file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAssetInfo()
        {
            lblAssetName.Text = "Asset Name: " + asset.AssetName;
            lblDescription.Text = "Description: " + asset.AssetDescription;
            lblDate.Text = "Date: " + asset.DateAdded.ToString("yyyy-MM-dd hh:mm tt");

            if (File.Exists(asset.AssetImagePath))
                picPreview.Image = Image.FromFile(asset.AssetImagePath);
        }

        private void LogViewerActivity()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO ViewerActivity (AssetID, ViewerEmail, ViewedAt) VALUES (@AssetID, @Email, NOW())";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AssetID", asset.AssetId);
                        cmd.Parameters.AddWithValue("@Email", viewerEmail);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging viewer activity:\n" + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // ✅ Track logout
            UserSessionHelper.LogSession(viewerTag, viewerEmail, "Viewer", "Logout");

            OnLogoutClicked?.Invoke();
            new LoginForm().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm();
            if (parent is MainForm mainForm)
            {
                var gallery = new ViewerGalleryControl(viewerEmail);

                gallery.OnAssetSelected += asset =>
                {
                    var viewer = new Viewer3DViewerControl(asset, viewerEmail);
                    mainForm.LoadForm(viewer);
                };

                gallery.OnLogoutClicked += () =>
                {
                    // ✅ Track logout
                    UserSessionHelper.LogSession(viewerTag, viewerEmail, "Viewer", "Logout");

                    this.Hide();
                    new LoginForm().Show();
                };

                mainForm.LoadForm(gallery);
            }
        }
    }
}
