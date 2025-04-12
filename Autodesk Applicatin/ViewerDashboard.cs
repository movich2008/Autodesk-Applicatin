using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using MySql.Data.MySqlClient;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using Brushes = System.Windows.Media.Brushes;

namespace Autodesk_Applicatin
{
    public partial class ViewerDashboard : Form
    {
        private HelixViewport3D helixViewport;
        private int currentAssetID = 1;
        private Timer sliderTimer;
        private List<int> assetIDs;
        private bool isSlideshowStoppedByUser = false;

        public ViewerDashboard(string role)
        {
            InitializeComponent();
            Initialize3DView();
            InitializeTimer();
        }

        private void Initialize3DView()
        {
            helixViewport = new HelixViewport3D
            {
                Background = Brushes.LightGray,
                ZoomExtentsWhenLoaded = true,
                ShowCoordinateSystem = false,
                IsHeadLightEnabled = true,
                ShowCameraInfo = false,
                ShowViewCube = false
            };

            elementHost.Child = helixViewport;
        }

        private void InitializeTimer()
        {
            sliderTimer = new Timer();
            sliderTimer.Interval = 5000;
            sliderTimer.Tick += SliderTimer_Tick;
            sliderTimer.Start();
        }

        private void SliderTimer_Tick(object sender, EventArgs e)
        {
            if (isSlideshowStoppedByUser) return;

            assetIDs = GetAllAssetIDs();
            if (assetIDs.Count == 0) return;

            int nextIndex = (assetIDs.IndexOf(currentAssetID) + 1) % assetIDs.Count;
            int attempts = 0;

            while (attempts < assetIDs.Count)
            {
                currentAssetID = assetIDs[nextIndex];
                if (LoadAssetFromDatabase(currentAssetID)) return;
                nextIndex = (nextIndex + 1) % assetIDs.Count;
                attempts++;
            }

            MessageBox.Show("No valid 3D assets could be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private List<int> GetAllAssetIDs()
        {
            var ids = new List<int>();
            string query = "SELECT AssetID FROM Assets";

            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        ids.Add(reader.GetInt32(0));
                }
            }

            return ids;
        }

        private bool LoadAssetFromDatabase(int assetID)
        {
            string assetFilePath = GetAssetFilePathFromDatabase(assetID);
            Console.WriteLine($"Loading AssetID: {assetID}, File: {assetFilePath}");

            if (string.IsNullOrEmpty(assetFilePath) || !File.Exists(assetFilePath))
                return false;

            var model = LoadModelFromFile(assetFilePath);
            if (model == null || model.Bounds == Rect3D.Empty)
                return false;

            helixViewport.Children.Clear();
            helixViewport.Children.Add(new ModelVisual3D { Content = model });
            helixViewport.Children.Add(new DefaultLights());

            try
            {
                helixViewport.ZoomExtents();
            }
            catch (Exception ex)
            {
             MessageBox.Show("ZoomExtents failed: " + ex.Message);
                return false;
            }

            return true;
        }

        private Model3D LoadModelFromFile(string path)
        {
            try
            {
                var importer = new ObjReader();
                return importer.Read(path);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error loading 3D model: " + ex.Message);
                return null;
            }
        }

        private string GetAssetFilePathFromDatabase(int assetID) => FetchString("SELECT AssetFilePath FROM Assets WHERE AssetID = @AssetID", assetID);
        private string GetAssetImageFromDatabase(int assetID) => FetchString("SELECT AssetImagePath FROM Assets WHERE AssetID = @AssetID", assetID);
        private string GetAssetNameFromDatabase(int assetID) => FetchString("SELECT AssetName FROM Assets WHERE AssetID = @AssetID", assetID);
        private string GetAssetDescriptionFromDatabase(int assetID) => FetchString("SELECT AssetDescription FROM Assets WHERE AssetID = @AssetID", assetID);
        private string GetAssetDateFromDatabase(int assetID) => FetchString("SELECT DateAdded FROM Assets WHERE AssetID = @AssetID", assetID);

        private string FetchString(string query, int assetID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssetID", assetID);
                conn.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        private void btnAssetDetails_Click(object sender, EventArgs e)
        {
            string imagePath = GetAssetImageFromDatabase(currentAssetID);
            string name = GetAssetNameFromDatabase(currentAssetID);
            string description = GetAssetDescriptionFromDatabase(currentAssetID);
            string date = GetAssetDateFromDatabase(currentAssetID);
            string ext2D = Path.GetExtension(imagePath);
            string ext3D = Path.GetExtension(GetAssetFilePathFromDatabase(currentAssetID));

            string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            Image image = File.Exists(fullImagePath) ? Image.FromFile(fullImagePath) : null;

            var popup = new AssetDetailsPopup();
            UIHelper.PopulateAssetDetails(popup, name, description, date, ext2D, ext3D, image);
            popup.ShowDialog();
        }

        private void btnViewAssets_Click(object sender, EventArgs e)
        {
            assetIDs = GetAllAssetIDs();
            var gallery = new AssetGalleryForm();

            UIHelper.PopulateAssetGallery(
                gallery,
                assetIDs,
                GetAssetNameFromDatabase,
                GetAssetImageFromDatabase,
                (selectedAssetID) =>
                {
                    currentAssetID = selectedAssetID;
                    isSlideshowStoppedByUser = true; // ⛔ Stop timer permanently
                    pnlMainContent.Controls.Clear();
                    pnlMainContent.Controls.Add(elementHost);
                    elementHost.Dock = DockStyle.Fill;
                    LoadAssetFromDatabase(selectedAssetID);
                }
            );

            gallery.ShowDialog();
        }

        private void ViewerDashboard_Load_1(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(elementHost);
            elementHost.Dock = DockStyle.Fill;
            LoadAssetFromDatabase(currentAssetID);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void elementHost_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }
    }
}
