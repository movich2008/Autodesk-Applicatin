using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class Admin3DViewer : UserControl
    {
        private string assetId;
        private string assetName;
        private string modelPath;
        private string imagePath;
        private string description;
        private DateTime dateAdded;

        private HelixViewport3D helixViewport;

        public Admin3DViewer(string assetId)
        {
            InitializeComponent();
            this.assetId = assetId;
            LoadAssetFromDatabase();
        }

        private void LoadAssetFromDatabase()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT AssetName, AssetDescription, AssetFilePath, AssetImagePath, DateAdded FROM assets WHERE AssetID = @AssetID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssetID", assetId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            assetName = reader["AssetName"].ToString();
                            description = reader["AssetDescription"].ToString();
                            modelPath = reader["AssetFilePath"].ToString();
                            imagePath = reader["AssetImagePath"].ToString();
                            dateAdded = Convert.ToDateTime(reader["DateAdded"]);
                        }
                        else
                        {
                            MessageBox.Show("Asset not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            Setup3DViewer();
            Load3DModel();
        }

        private void Setup3DViewer()
        {
            helixViewport = new HelixViewport3D
            {
                Camera = new PerspectiveCamera
                {
                    Position = new Point3D(0, 0, 10),
                    LookDirection = new Vector3D(0, 0, -10),
                    UpDirection = new Vector3D(0, 1, 0),
                    FieldOfView = 45
                },
                ZoomExtentsWhenLoaded = true,
                ShowCoordinateSystem = false,
                IsHeadLightEnabled = true,
                ShowCameraInfo = false,
                ShowViewCube = false,
                Background = System.Windows.Media.Brushes.LightGray
            };

            elementHost3D.Child = helixViewport;
        }

        private void Load3DModel()
        {
            try
            {
                if (!File.Exists(modelPath))
                {
                    MessageBox.Show("3D model file not found:\n" + modelPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var importer = new ObjReader();
                Model3D model = importer.Read(modelPath);
                helixViewport.Children.Clear();
                helixViewport.Children.Add(new ModelVisual3D { Content = model });
                helixViewport.Children.Add(new DefaultLights());
                helixViewport.ZoomExtents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load 3D model: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            AdminAssetDetails detailsForm = new AdminAssetDetails(
                assetName,
                description,
                modelPath,
                imagePath,
                dateAdded
            );
            detailsForm.ShowDialog();
        }
    }
}
