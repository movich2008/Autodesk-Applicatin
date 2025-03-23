using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using HelixToolkit.Wpf;   // For 3D rendering
using System.Windows.Media.Media3D; // For 3D objects
using System.Windows.Media; // For Brushes
using System.Windows.Forms.Integration;
using System.Configuration; // For ElementHost
using System.IO; // For File Checking
using System.Windows.Input; // Needed for MouseGesture & MouseAction


namespace Autodesk_Applicatin
{
    public partial class ViewerDashboard : Form
    {
        private HelixViewport3D helixViewport;
        private int currentAssetID = 1;
        private Timer sliderTimer;
        private List<int> assetIDs;

        public ViewerDashboard(string role)
        {
            InitializeComponent();
            Initialize3DView();
            LoadAssetFromDatabase(currentAssetID);
            InitializeTimer();
        }

        private void Initialize3DView()
        {
            helixViewport = new HelixViewport3D
            {
                Background = Brushes.LightGray,
                ZoomExtentsWhenLoaded = true, 
                ShowCoordinateSystem = false,  
                IsHeadLightEnabled = true,     // Ensures lighting follows camera
                ShowCameraInfo = false,
                ShowViewCube = false
            };


            elementHost.Child = helixViewport;
            helixViewport.InputBindings.Clear();
        }

        private void InitializeTimer()
        {
            sliderTimer = new Timer();
            sliderTimer.Interval = 5000;
            sliderTimer.Tick += SliderTimerElapsed;
            sliderTimer.Start();
        }

        private void SliderTimerElapsed(object sender, EventArgs e)
        {
            sliderTimer.Stop();

            assetIDs = GetAllAssetIDs();
            if (assetIDs.Count == 0) return;

            int nextIndex = (assetIDs.IndexOf(currentAssetID) + 1) % assetIDs.Count;
            int attempts = 0;

            while (attempts < assetIDs.Count)
            {
                currentAssetID = assetIDs[nextIndex];
                bool loaded = LoadAssetFromDatabase(currentAssetID);

                if (loaded)
                {
                    sliderTimer.Start();
                    return;
                }

                nextIndex = (nextIndex + 1) % assetIDs.Count;
                attempts++;
            }

            MessageBox.Show("No valid 3D assets could be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private List<int> GetAllAssetIDs()
        {
            List<int> assetIDs = new List<int>();
            string query = "SELECT AssetID FROM Assets";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assetIDs.Add(reader.GetInt32(0));
                    }
                }
            }

            return assetIDs;
        }

        private bool LoadAssetFromDatabase(int assetID)
        {
            string assetFilePath = GetAssetFilePathFromDatabase(assetID);
            string assetImagePath = GetAssetImageFromDatabase(assetID);

            string asset3DFileType = Path.GetExtension(assetFilePath);
            string asset2DFileType = Path.GetExtension(assetImagePath);

            Console.WriteLine($"AssetID: {assetID}, 3DFile: {assetFilePath}, 2DFile: {assetImagePath}");

            lbl3dFilePath.Text = $"3D File Type: {asset3DFileType}";
            lbl2dFilePath.Text = $"2D File Type: {asset2DFileType}";

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string absoluteImagePath = Path.Combine(basePath, assetImagePath);

            if (!string.IsNullOrEmpty(assetImagePath) && File.Exists(absoluteImagePath))
            {
                picAssetViewer.SizeMode = PictureBoxSizeMode.StretchImage;
                picAssetViewer.ImageLocation = absoluteImagePath;
            }
            else
            {
                picAssetViewer.Image = null;
                Console.WriteLine($"Warning: 2D preview image not found at: {absoluteImagePath}");
            }

            if (!string.IsNullOrEmpty(assetFilePath) && File.Exists(assetFilePath))
            {
                var model = LoadModelFromFile(assetFilePath);
                if (model == null || model.Bounds == Rect3D.Empty)
                {
                    Console.WriteLine("3D model failed to load or has no geometry.");
                    return false;
                }

                var modelVisual = new ModelVisual3D { Content = model };
                helixViewport.Children.Clear();
                helixViewport.Children.Add(modelVisual);

                var lights = new DefaultLights();
                helixViewport.Children.Add(lights);

                try
                {
                    helixViewport.ZoomExtents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ZoomExtents failed: " + ex.Message, "Zoom Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("3D file path is invalid or file does not exist.");
                return false;
            }

            lblAssetName.Text = "Asset Name: " + GetAssetNameFromDatabase(assetID);
            lblAssetDescription.Text = "Description: " + GetAssetDescriptionFromDatabase(assetID);
            lblDate.Text = "Date Added: " + GetAssetDateFromDatabase(assetID);

            return true;
        }

        private Model3D LoadModelFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var importer = new ObjReader();
                    return importer.Read(filePath);
                }
                else
                {
                    MessageBox.Show("3D model file not found at:\n" + filePath, "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading 3D model: " + ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string GetAssetFilePathFromDatabase(int assetID)
        {
            return FetchSingleStringValue("SELECT AssetFilePath FROM Assets WHERE AssetID = @AssetID", assetID);
        }

        private string GetAssetImageFromDatabase(int assetID)
        {
            return FetchSingleStringValue("SELECT AssetImagePath FROM Assets WHERE AssetID = @AssetID", assetID);
        }

        private string GetAssetNameFromDatabase(int assetID)
        {
            return FetchSingleStringValue("SELECT AssetName FROM Assets WHERE AssetID = @AssetID", assetID);
        }

        private string GetAssetDescriptionFromDatabase(int assetID)
        {
            return FetchSingleStringValue("SELECT AssetDescription FROM Assets WHERE AssetID = @AssetID", assetID);
        }

        private string GetAssetDateFromDatabase(int assetID)
        {
            return FetchSingleStringValue("SELECT DateAdded FROM Assets WHERE AssetID = @AssetID", assetID);
        }

        private string FetchSingleStringValue(string query, int assetID)
        {
            string result = "";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AssetID", assetID);
                conn.Open();
                result = cmd.ExecuteScalar()?.ToString();
            }
            return result;
        }

        private void btnViewAssets_Click(object sender, EventArgs e) { }
        private void btnAssetDetails_Click(object sender, EventArgs e) { }
        private void ViewerDashboard_Load(object sender, EventArgs e) { }
        private void elementHost_ChildChanged(object sender, ChildChangedEventArgs e) { }
    }
}
