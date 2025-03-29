using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class AdminAssetEditForm : UserControl
    {
        private string assetId;
        private string selectedModelPath = "";
        private string selectedImagePath = "";
        private HelixViewport3D helixViewport;

        public AdminAssetEditForm(string assetId)
        {
            InitializeComponent();
            this.assetId = assetId;
            LoadAssetData(assetId);
        }

        private void LoadAssetData(string id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT AssetName, AssetDescription, AssetFilePath, AssetImagePath FROM assets WHERE AssetID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtEditAssetName.Text = reader["AssetName"].ToString();
                    txtEditDescription.Text = reader["AssetDescription"].ToString();
                    selectedModelPath = reader["AssetFilePath"].ToString();
                    selectedImagePath = reader["AssetImagePath"].ToString();
                    lblModelPath.Text = Path.GetFileName(selectedModelPath);
                    lblImagePath.Text = Path.GetFileName(selectedImagePath);

                    if (File.Exists(selectedImagePath))
                        pic2DPreview.Image = Image.FromFile(selectedImagePath);

                    helixViewport = new HelixViewport3D
                    {
                        Camera = new PerspectiveCamera(new Point3D(0, 0, 10), new Vector3D(0, 0, -10), new Vector3D(0, 1, 0), 45),
                        ZoomExtentsWhenLoaded = true,
                        ShowCoordinateSystem = false,
                        ShowViewCube = false,
                        IsHeadLightEnabled = true,
                        Background = System.Windows.Media.Brushes.LightGray
                    };

                    if (File.Exists(selectedModelPath))
                    {
                        var importer = new ObjReader();
                        Model3D model = importer.Read(selectedModelPath);
                        helixViewport.Children.Add(new ModelVisual3D { Content = model });
                        helixViewport.Children.Add(new DefaultLights());
                    }

                    eleHost3D.Child = helixViewport;
                }
            }
        }

        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dlg.FileName;
                lblImagePath.Text = Path.GetFileName(selectedImagePath);
                pic2DPreview.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void BtnBrowseModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog { Filter = "3D Files|*.obj" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedModelPath = dlg.FileName;
                lblModelPath.Text = Path.GetFileName(selectedModelPath);

                var reader = new ObjReader();
                Model3D model = reader.Read(selectedModelPath);
                helixViewport.Children.Clear();
                helixViewport.Children.Add(new ModelVisual3D { Content = model });
                helixViewport.Children.Add(new DefaultLights());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string assetsFolder = Path.Combine(Application.StartupPath, "Assets");
            Directory.CreateDirectory(assetsFolder);

            string newModelPath = Path.Combine(assetsFolder, Path.GetFileName(selectedModelPath));
            string newImagePath = Path.Combine(assetsFolder, Path.GetFileName(selectedImagePath));

            if (File.Exists(selectedModelPath)) File.Copy(selectedModelPath, newModelPath, true);
            if (File.Exists(selectedImagePath)) File.Copy(selectedImagePath, newImagePath, true);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE assets SET AssetName = @name, AssetDescription = @desc, AssetFilePath = @model, AssetImagePath = @img, DateAdded = NOW() WHERE AssetID = @id", conn);
                cmd.Parameters.AddWithValue("@name", txtEditAssetName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtEditDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@model", newModelPath);
                cmd.Parameters.AddWithValue("@img", newImagePath);
                cmd.Parameters.AddWithValue("@id", assetId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Asset updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var parent = this.Parent as Panel;
            parent?.Controls.Clear();
            var refreshedControl = new AdminAssetControl();
            refreshedControl.Dock = DockStyle.Fill;
            parent?.Controls.Add(refreshedControl);
        }

        private void AdminAssetEditForm_Load(object sender, EventArgs e)
        {
            btnBrowseImage.Click += BtnBrowseImage_Click;
            btnBrowseModel.Click += BtnBrowseModel_Click;
            btnSave.Click += BtnSave_Click;
        }
    }
}