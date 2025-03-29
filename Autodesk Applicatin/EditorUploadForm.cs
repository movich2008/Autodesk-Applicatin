using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using System.Windows.Media;
using System.Windows.Forms.Integration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace Autodesk_Applicatin
{
    public partial class EditorUploadForm : Form
    {
        private string selected3DPath = "";
        private string selected2DPath = "";
        private int editingAssetId = -1; // -1 means new upload
        private HelixViewport3D helixViewport;
        private string userRole;
        public EditorUploadForm(string role)
        {
            InitializeComponent();
            userRole = role;
            Initialize3DViewer();
        }

        private void Initialize3DViewer()
        {
            helixViewport = new HelixViewport3D
            {
                Background = Brushes.LightGray,
                ZoomExtentsWhenLoaded = true,
                ShowViewCube = false,
                ShowCoordinateSystem = false,
                IsHeadLightEnabled = true
            };

            elementHost3D.Child = helixViewport;
        }
        // Loading 3D Model from file
        private Model3D LoadModelFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var importer = new ObjReader(); // Works best for .obj files
                    return importer.Read(filePath);
                }
                else
                {
                    MessageBox.Show("3D model file not found at:\n" + filePath, "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load 3D model:\n" + ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Call this when editing
        public void LoadAssetForEditing(int assetId, string name, string description, string imagePath, string modelPath)
        {
            // Store the asset ID for later update
            this.editingAssetId = assetId;

            // Populate fields
            txtAssetName.Text = name;
            txtAssetDescription.Text = description;
            selected2DPath = imagePath;
            lbl2dPreviewPath.Text = $"Image Path: {selected2DPath}";
            selected3DPath = modelPath;
            lbl3dPreviewPath.Text = $"Model Path: {selected3DPath}";

            // Show 2D preview
            if (File.Exists(imagePath))
            {
                picAssetPreview.ImageLocation = imagePath;
                picAssetPreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picAssetPreview.Image = null;
            }

            // Show 3D preview
            if (File.Exists(modelPath))
            {
                var model = LoadModelFromFile(modelPath);
                if (model != null)
                {
                    var modelVisual = new ModelVisual3D { Content = model };
                    helixViewport.Children.Clear();
                    helixViewport.Children.Add(modelVisual);
                    helixViewport.Children.Add(new DefaultLights());
                    helixViewport.ZoomExtents();
                }
            }

            // Update button label
            btnUpload.Text = "Update Asset";
        }


        private void btnSelect2D_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selected2DPath = openFileDialog.FileName;
                picAssetPreview.ImageLocation = selected2DPath;
            }
        }

        private void btnSelect3D_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "3D Model Files|*.obj";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selected3DPath = openFileDialog.FileName;
                Load3DModel(selected3DPath);
            }
        }

        private void Load3DModel(string path)
        {
            try
            {
                helixViewport.Children.Clear();
                var model = new ObjReader().Read(path);
                if (model != null)
                {
                    helixViewport.Children.Add(new ModelVisual3D { Content = model });
                    helixViewport.Children.Add(new DefaultLights());
                    helixViewport.ZoomExtents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load 3D model: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string assetName = txtAssetName.Text.Trim();
            string description = txtAssetDescription.Text.Trim();

            // Copy files to Assets folder
            string assetsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
            Directory.CreateDirectory(assetsFolder);

            string newImagePath = Path.Combine("Assets", Path.GetFileName(selected2DPath));
            string newModelPath = Path.Combine("Assets", Path.GetFileName(selected3DPath));

            File.Copy(selected2DPath, Path.Combine(assetsFolder, Path.GetFileName(selected2DPath)), true);
            File.Copy(selected3DPath, Path.Combine(assetsFolder, Path.GetFileName(selected3DPath)), true);

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = editingAssetId == -1
                    ? "INSERT INTO Assets (AssetName, AssetDescription, AssetImagePath, AssetFilePath, DateAdded) VALUES (@name, @desc, @image, @model, NOW())"
                    : "UPDATE Assets SET AssetName = @name, AssetDescription = @desc, AssetImagePath = @image, AssetFilePath = @model WHERE AssetID = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", assetName);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@image", newImagePath);
                cmd.Parameters.AddWithValue("@model", newModelPath);

                if (editingAssetId != -1)
                    cmd.Parameters.AddWithValue("@id", editingAssetId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(editingAssetId == -1 ? "Asset uploaded successfully!" : "Asset updated successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtAssetName.Text) ||
                string.IsNullOrWhiteSpace(txtAssetDescription.Text) ||
                string.IsNullOrWhiteSpace(selected2DPath) ||
                string.IsNullOrWhiteSpace(selected3DPath))
            {
                MessageBox.Show("Please fill in all fields and select both 2D and 3D files.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Load3DPreview(string modelPath)
        {
            try
            {
                if (File.Exists(modelPath))
                {
                    var importer = new ObjReader();
                    var model = importer.Read(modelPath);

                    var modelVisual = new ModelVisual3D { Content = model };

                    var helixViewport = new HelixViewport3D
                    {
                        Background = Brushes.LightGray,
                        ShowCoordinateSystem = false,
                        ShowCameraInfo = false,
                        ShowViewCube = false,
                        IsHeadLightEnabled = true
                    };

                    helixViewport.Children.Add(new DefaultLights());
                    helixViewport.Children.Add(modelVisual);
                    helixViewport.ZoomExtents();

                    // Display in the ElementHost
                    elementHost3D.Child = helixViewport;
                }
                else
                {
                    MessageBox.Show("3D file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading 3D model:\n" + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSelect3D_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "3D Model Files (*.obj)|*.obj";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbl3dPreviewPath.Text = ofd.FileName;
                    Load3DPreview(ofd.FileName); // assumes LoadModelFromFile logic here
                }
            }
        }

        private void btnSelect2D_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbl2dPreviewPath.Text = ofd.FileName;
                    picAssetPreview.ImageLocation = ofd.FileName;
                    picAssetPreview.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void EditorUploadForm_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
        }
    }
}
