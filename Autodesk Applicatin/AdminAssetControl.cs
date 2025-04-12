using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{

    public partial class AdminAssetControl : UserControl
    {
        public AdminAssetControl()
        {
            InitializeComponent();
           
        }

        private void AdminAssetControl_Load(object sender, EventArgs e)
        {
           LoadAssets();
        }

        private void LoadAssets()
        {
            flowAssets.Controls.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT AssetID, AssetName, AssetImagePath FROM assets";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string assetId = reader["AssetID"].ToString();
                        string assetName = reader["AssetName"].ToString();
                        string imagePath = reader["AssetImagePath"].ToString();

                        Panel card = CreateAssetCard(assetId, assetName, imagePath);
                        flowAssets.Controls.Add(card);
                    }
                }
            }
        }

        private Panel CreateAssetCard(string assetId, string name, string imagePath)
        {
            string fallbackPath = Path.Combine(Application.StartupPath, "Assets", "no_preview.png");
            Image previewImage = File.Exists(imagePath) ? Image.FromFile(imagePath) : Image.FromFile(fallbackPath);

            Panel panel = new Panel
            {
                Width = 200,
                Height = 260,
                Margin = new Padding(15, 20, 15, 10),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pic = new PictureBox
            {
                Width = 180,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = previewImage
            };

            Label lblName = new Label
            {
                Text = name,
                AutoSize = false,
                Width = 180,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            Button btnView = new Button
            {
                Text = "View",
                Name = "btnViewAsset",
                Width = 50,
                Tag = assetId
            };

            Button btnEdit = new Button
            {
                Text = "Edit",
                Name = "btnEditAsset",
                Width = 50,
                Tag = assetId
            };

            Button btnDelete = new Button
            {
                Text = "Delete",
                Name = "btnDeleteAsset",
                Width = 60,
                Tag = assetId
            };

            btnView.Click += BtnView_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            FlowLayoutPanel btnPanel = new FlowLayoutPanel
            {
                Width = 180,
                Height = 35,
                FlowDirection = FlowDirection.LeftToRight
            };
            btnPanel.Controls.AddRange(new Control[] { btnView, btnEdit, btnDelete });

            panel.Controls.Add(pic);
            panel.Controls.Add(lblName);
            panel.Controls.Add(btnPanel);

            // Layout
            pic.Top = 10;
            pic.Left = 10;

            lblName.Top = pic.Bottom + 5;
            lblName.Left = 10;

            btnPanel.Top = lblName.Bottom + 5;
            btnPanel.Left = 10;

            return panel;
        }



        private void BtnView_Click(object sender, EventArgs e)
        {
            string assetId = (sender as Button).Tag.ToString();

            // Clear pnlMain and load Admin3DViewer dynamically
            var viewer = new Admin3DViewer(assetId);
            viewer.Dock = DockStyle.Fill;

            // Find the parent form and its pnlMain
            Form parentForm = this.FindForm();
            Panel pnlMain = parentForm.Controls["pnlMain"] as Panel;

            if (pnlMain != null)
            {
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(viewer);
            }
            else
            {
                MessageBox.Show("Main panel not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string assetId = (sender as Button).Tag.ToString();

            // Find the parent Form (AdminDashboard) and access pnlMain
            Control parent = this;
            while (parent != null && !(parent is AdminDashboard))
                parent = parent.Parent;

            if (parent is AdminDashboard adminDashboard)
            {
                Panel pnlMain = adminDashboard.Controls["pnlMain"] as Panel;

                if (pnlMain != null)
                {
                    pnlMain.Controls.Clear();

                    AdminAssetEditForm editForm = new AdminAssetEditForm(assetId);
                    editForm.Dock = DockStyle.Fill;

                    pnlMain.Controls.Add(editForm);
                }
            }
            else
            {
                MessageBox.Show("Failed to find main dashboard panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string assetId = (sender as Button).Tag.ToString();

            if (MessageBox.Show("Are you sure you want to delete this asset?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM assets WHERE AssetID = @AssetID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // 🛠 Convert assetId to integer safely
                        if (int.TryParse(assetId, out int id))
                        {
                            cmd.Parameters.AddWithValue("@AssetID", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Asset Successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Asset ID. Cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                LoadAssets(); // Refresh after delete
            }
        }


        private void btnUploadAsset_Click(object sender, EventArgs e)
        {
            // Step 1: Select 2D preview image
            OpenFileDialog imgDialog = new OpenFileDialog();
            imgDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (imgDialog.ShowDialog() != DialogResult.OK) return;

            string imgFile = imgDialog.FileName;
            string imgFileName = Path.GetFileName(imgFile);
            string imgDestPath = Path.Combine(Application.StartupPath, "Assets", imgFileName);
            Directory.CreateDirectory(Path.GetDirectoryName(imgDestPath));
            File.Copy(imgFile, imgDestPath, true);

            // Step 2: Select 3D model file (.obj)
            OpenFileDialog modelDialog = new OpenFileDialog();
            modelDialog.Filter = "3D Model files (*.obj)|*.obj";

            if (modelDialog.ShowDialog() != DialogResult.OK) return;

            string modelFile = modelDialog.FileName;
            string modelFileName = Path.GetFileName(modelFile);
            string modelDestPath = Path.Combine(Application.StartupPath, "Assets", modelFileName);
            File.Copy(modelFile, modelDestPath, true);

            string assetName = Path.GetFileNameWithoutExtension(modelFileName); // default name from 3D file

            // Step 3: Insert into DB
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string insert =
                    "INSERT INTO assets (AssetName, AssetImagePath, AssetFilePath, DateAdded) VALUES (@Name, @ImagePath, @ModelPath, NOW())";
                using (var cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", assetName);
                    cmd.Parameters.AddWithValue("@ImagePath", imgDestPath);
                    cmd.Parameters.AddWithValue("@ModelPath", modelDestPath);
                    cmd.ExecuteNonQuery();

                    long insertedId = cmd.LastInsertedId;

                    // 🟢 Now use real ID
                    Panel newCard = CreateAssetCard(insertedId.ToString(), assetName, imgDestPath);
                    flowAssets.Controls.Add(newCard);
                    flowAssets.Controls.SetChildIndex(newCard, 0); // put at top-left

                    flowAssets.VerticalScroll.Value = 0;
                    flowAssets.PerformLayout();
                }

            }

        }

        private void flowAssets_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
