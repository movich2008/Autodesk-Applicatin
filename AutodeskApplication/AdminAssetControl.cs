using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutodeskApplication
{
    public partial class AdminAssetControl : UserControl
    {
        private string currentUserEmail;
        private string currentUserRole;

        public AdminAssetControl(string userEmail, string role)
        {
            InitializeComponent();
            this.currentUserEmail = userEmail;
            this.currentUserRole = role;
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
                Width = 50,
                Tag = assetId
            };
            btnView.Click += BtnView_Click;

            Button btnEdit = new Button
            {
                Text = "Edit",
                Width = 50,
                Tag = assetId,
                Visible = currentUserRole == "Admin"
            };
            btnEdit.Click += BtnEdit_Click;

            Button btnDelete = new Button
            {
                Text = "Delete",
                Width = 60,
                Tag = assetId,
                Visible = currentUserRole == "Admin"
            };
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

            if (int.TryParse(assetId, out int id))
            {
                if (currentUserRole == "Viewer")
                {
                    LogViewerActivity(currentUserEmail, id);
                }

                AssetDetails details = GetAssetDetailsById(id);

                if (details != null)
                {
                    var viewer = new Viewer3DViewerControl(details, currentUserEmail);
                    viewer.Dock = DockStyle.Fill;

                    Form parentForm = this.FindForm();
                    Panel pnlMain = parentForm.Controls["pnlMain"] as Panel;

                    if (pnlMain != null)
                    {
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(viewer);
                    }
                }
                else
                {
                    MessageBox.Show("Asset details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private AssetDetails GetAssetDetailsById(int assetId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM assets WHERE AssetID = @AssetID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssetID", assetId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AssetDetails
                            {
                                AssetId = assetId,
                                AssetName = reader["AssetName"].ToString(),
                                AssetDescription = reader["AssetDescription"].ToString(),
                                AssetImagePath = reader["AssetImagePath"].ToString(),
                                AssetFilePath = reader["AssetFilePath"].ToString(),
                                DateAdded = Convert.ToDateTime(reader["DateAdded"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        private void LogViewerActivity(string viewerEmail, int assetId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ViewerActivity (AssetID, ViewerEmail, ViewedAt) VALUES (@AssetID, @Email, NOW())";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssetID", assetId);
                    cmd.Parameters.AddWithValue("@Email", viewerEmail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string assetId = (sender as Button).Tag.ToString();

            Control parent = this;
            while (parent != null && !(parent is AdminDashboard))
                parent = parent.Parent;

            if (parent is AdminDashboard adminDashboard)
            {
                Panel pnlMain = adminDashboard.Controls["pnlMain"] as Panel;

                if (pnlMain != null)
                {
                    pnlMain.Controls.Clear();
                    var editForm = new AdminAssetEditForm(assetId, currentUserEmail, currentUserRole);
                    editForm.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(editForm);
                }
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
                        if (int.TryParse(assetId, out int id))
                        {
                            cmd.Parameters.AddWithValue("@AssetID", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Asset successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Asset ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                LoadAssets();
            }
        }
    }
}
