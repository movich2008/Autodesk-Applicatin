using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HelixToolkit.Wpf;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Autodesk_Applicatin
{
    public partial class EditorUploadForm : Form
    {
        private readonly string userRole;
        private readonly string editorEmail;

        private int editingAssetId = -1;
        private string selected3DPath = "";
        private string selected2DPath = "";

        public EditorUploadForm(string role, string email)
        {
            InitializeComponent();
            userRole = role;
            editorEmail = email;
        }

        private void EditorUploadForm_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);

            txtAssetDescription.Multiline = true;
            txtAssetDescription.ScrollBars = ScrollBars.Vertical;
            txtAssetDescription.WordWrap = true;

        }

        // 🔍 Select 3D File (.obj)
        private void btnSelect3D_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "3D Models (*.obj)|*.obj";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selected3DPath = ofd.FileName;
                    lbl3dPreviewPath.Text = Path.GetFileName(selected3DPath);
                    Load3DModelPreview(selected3DPath);
                }
            }
        }

        // 🎯 Load 3D Preview (Improved version)
        private void Load3DModelPreview(string path)
        {
            try
            {
                var modelImporter = new ModelImporter();
                var model = modelImporter.Load(path);

                var viewport = new HelixViewport3D
                {
                    //Background = System.Windows.Media.Brushes.White,
                    ShowCoordinateSystem = false,
                    ShowViewCube = false,
                    ZoomExtentsWhenLoaded = true,
                    IsHeadLightEnabled = true,
                    ShowCameraInfo = false,
                    ShowFrameRate = false
                };

                viewport.Children.Add(new DefaultLights());
                viewport.Children.Add(new ModelVisual3D { Content = model });

                // Center the camera
                var bounds = model.Bounds;
                var center = bounds.Location + new Vector3D(bounds.SizeX / 2, bounds.SizeY / 2, bounds.SizeZ / 2);

                viewport.Camera = new PerspectiveCamera
                {
                    Position = center + new Vector3D(0, 0, bounds.SizeZ * 2),
                    LookDirection = new Vector3D(0, 0, -bounds.SizeZ * 2),
                    UpDirection = new Vector3D(0, 1, 0),
                    FieldOfView = 45
                };

                elementHost3D.Child = viewport;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load 3D model: " + ex.Message);
            }
        }

        // 🖼️ Select 2D Image (PNG/JPG)
        private void btnSelect2D_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selected2DPath = ofd.FileName;
                    lbl2dPreviewPath.Text = Path.GetFileName(selected2DPath);
                    picAssetPreview.Image = Image.FromFile(selected2DPath);
                }
            }
        }

        // ⬆ Upload or Update to MySQL
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string name = txtAssetName.Text.Trim();
            string description = txtAssetDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(selected3DPath) || string.IsNullOrEmpty(selected2DPath))
            {
                MessageBox.Show("Please fill in all required fields and select files.");
                return;
            }

            string assetsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
            Directory.CreateDirectory(assetsFolder);

            string new3DPath = Path.Combine("Assets", $"{Guid.NewGuid()}.obj");
            string new2DPath = Path.Combine("Assets", $"{Guid.NewGuid()}.png");

            File.Copy(selected3DPath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, new3DPath), true);
            File.Copy(selected2DPath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, new2DPath), true);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query;
                if (editingAssetId == -1)
                {
                    query = @"INSERT INTO Assets (AssetName, AssetDescription, AssetFilePath, AssetImagePath, DateAdded, status, status_updated_by, status_updated_at, EditorEmail)
                              VALUES (@name, @desc, @filePath, @imagePath, NOW(), 'Pending', @editor, NOW(), @editor)";
                }
                else
                {
                    query = @"UPDATE Assets 
                              SET AssetName = @name, 
                                  AssetDescription = @desc, 
                                  AssetFilePath = @filePath, 
                                  AssetImagePath = @imagePath, 
                                  status = 'Pending',
                                  status_updated_by = @editor,
                                  status_updated_at = NOW()
                              WHERE AssetID = @id";
                }

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@filePath", new3DPath);
                    cmd.Parameters.AddWithValue("@imagePath", new2DPath);
                    cmd.Parameters.AddWithValue("@editor", editorEmail);

                    if (editingAssetId != -1)
                        cmd.Parameters.AddWithValue("@id", editingAssetId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Asset uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var dashboard = new EditorDashboard(userRole, editorEmail);
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;

            var parentPanel = this.Parent as Panel; // Assuming it's loaded inside pnlEditor
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(dashboard);
                dashboard.Show();
            }

        }

        // 🛠️ Load data for edit mode
        public void LoadAssetForEditing(int assetId, string name, string description, string imagePath, string modelPath)
        {
            editingAssetId = assetId;
            txtAssetName.Text = name;
            txtAssetDescription.Text = description;

            selected2DPath = imagePath;
            selected3DPath = modelPath;

            // Hide path labels
            lbl2dPreviewPath.Visible = false;
            lbl3dPreviewPath.Visible = false;

            // Enable file selection buttons so the editor can replace assets
            btnSelect2D.Enabled = true;
            btnSelect3D.Enabled = true;

            // Preview existing 2D image
            if (File.Exists(imagePath))
                picAssetPreview.Image = Image.FromFile(imagePath);

            // Preview existing 3D model
            if (File.Exists(modelPath))
                Load3DModelPreview(modelPath);

            // Title change
            lblTitleText.Text = "Edit Asset";
            // Optionally change btnUpload to reflect edit mode
            btnUpload.Text = "Save Changes";
        }




        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
