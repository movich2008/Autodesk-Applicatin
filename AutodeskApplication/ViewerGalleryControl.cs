using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutodeskApplication.Utilities;

namespace AutodeskApplication
{
    public partial class ViewerGalleryControl : UserControl
    {
        private string viewerEmail;
        private string viewerTag;

        public string ViewerEmail => viewerEmail;

        public event Action<AssetDetails> OnAssetSelected;
        public event Action OnLogoutClicked;

        public ViewerGalleryControl(string email)
        {
            InitializeComponent();
            viewerEmail = email;
            viewerTag = GetViewerTag(email); // ✅ fetch user tag
            LoadAssets();
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

        private void LoadAssets()
        {
            flowAssets.Controls.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT AssetID, AssetName, AssetDescription, AssetImagePath, AssetFilePath, DateAdded FROM Assets";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var asset = new AssetDetails
                        {
                            AssetId = Convert.ToInt32(reader["AssetID"]),
                            AssetName = reader["AssetName"].ToString(),
                            AssetDescription = reader["AssetDescription"].ToString(),
                            AssetImagePath = reader["AssetImagePath"].ToString(),
                            AssetFilePath = reader["AssetFilePath"].ToString(),
                            DateAdded = Convert.ToDateTime(reader["DateAdded"])
                        };

                        Panel card = CreateAssetCard(asset);
                        flowAssets.Controls.Add(card);
                    }
                }
            }
        }

        private Panel CreateAssetCard(AssetDetails asset)
        {
            Panel panel = new Panel
            {
                Width = 200,
                Height = 200,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
            };

            PictureBox picture = new PictureBox
            {
                Width = 200,
                Height = 100,
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(asset.AssetImagePath),
                Tag = asset,
                Cursor = Cursors.Hand
            };
            picture.Click += Picture_Click;

            Label lbl = new Label
            {
                Text = asset.AssetName,
                AutoSize = false,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel.Controls.Add(picture);
            panel.Controls.Add(lbl);
            return panel;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is AssetDetails asset)
            {
                OnAssetSelected?.Invoke(asset);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Track logout
            UserSessionHelper.LogSession(viewerTag, viewerEmail, "Viewer", "Logout");

            OnLogoutClicked?.Invoke();
            new LoginForm().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            foreach (Control ctrl in flowAssets.Controls)
            {
                if (ctrl is Panel panel && panel.Controls.OfType<Label>().FirstOrDefault() is Label lbl)
                {
                    panel.Visible = lbl.Text.ToLower().Contains(keyword);
                }
            }
        }
    }
}
