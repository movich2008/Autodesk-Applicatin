using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web.UI.Design;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace Autodesk_Applicatin
{
    public partial class EditorDashboard : Form
    {
        private readonly string userRole;
        private readonly string editorEmail;


        public EditorDashboard(string role, string email)
        {
            InitializeComponent();
            userRole = role;
           editorEmail = email;
        }

        private void EditorDashboard_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, lblNotificationCount.Width, lblNotificationCount.Height);
            lblNotificationCount.Region = new Region(gp);

            LoadAssetListToGrid();
            UpdateNotificationCount();
            UpdateCardStats();
            dgvAssets.CellFormatting += dgvAssets_CellFormatting;
        }

        private void picNotificationBell_Click(object sender, EventArgs e)
        {
            pnlNotifications.Visible = !pnlNotifications.Visible;

            if (pnlNotifications.Visible)
            {
                Point screenPoint = picNotificationBell.PointToScreen(Point.Empty);
                Point formPoint = this.PointToClient(screenPoint);

                pnlNotifications.Location = new Point(
                    formPoint.X + picNotificationBell.Width - pnlNotifications.Width,
                    formPoint.Y + picNotificationBell.Height + 5);

                pnlNotifications.BringToFront();
                LoadNotifications();
            }
        }

        private void LoadNotifications()
        {
            flowNotifications.Controls.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT AssetID, Message, IsRead, CreatedAt 
                                 FROM Notifications 
                                 WHERE EditorEmail = @Email 
                                 ORDER BY CreatedAt DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", editorEmail);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int assetId = Convert.ToInt32(reader["AssetID"]);
                            string message = reader["Message"].ToString();
                            bool isRead = Convert.ToBoolean(reader["IsRead"]);
                            DateTime createdAt = Convert.ToDateTime(reader["CreatedAt"]);
                            string timestamp = createdAt.ToString("dd MMM yyyy, hh:mm tt");

                            Label lbl = new Label
                            {
                                AutoSize = false,
                                Width = flowNotifications.Width - 20,
                                Height = 70,
                                Text = $"Asset #{assetId}\n{message}\n{timestamp}",
                                Padding = new Padding(10),
                                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                                BackColor = isRead ? Color.LightGray : Color.LightSalmon,
                                ForeColor = Color.Black,
                                TextAlign = ContentAlignment.TopLeft,
                                Cursor = Cursors.Hand,
                                Margin = new Padding(5),
                                Tag = assetId
                            };

                            lbl.Paint += (s, pe) =>
                            {
                                var g = pe.Graphics;
                                var bounds = lbl.ClientRectangle;
                                int radius = 10;

                                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                                {
                                    path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);
                                    path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);
                                    path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                                    path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);
                                    path.CloseAllFigures();

                                    lbl.Region = new Region(path);
                                }
                            };

                            lbl.Click += (s, e) =>
                            {
                                HighlightAssetInGrid(assetId);
                                MarkNotificationAsRead(assetId);
                                lbl.BackColor = Color.LightGray;
                                UpdateNotificationCount();
                            };

                            flowNotifications.Controls.Add(lbl);
                        }
                    }
                }
            }
        }

        private void HighlightAssetInGrid(int assetId)
        {
            foreach (DataGridViewRow row in dgvAssets.Rows)
            {
                if (Convert.ToInt32(row.Cells["AssetID"].Value) == assetId)
                {
                    row.Selected = true;
                    dgvAssets.FirstDisplayedScrollingRowIndex = row.Index;
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    break;
                }
            }
        }

        private void MarkNotificationAsRead(int assetId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Notifications 
                                 SET IsRead = 1 
                                 WHERE AssetID = @AssetID AND EditorEmail = @Email";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssetID", assetId);
                    cmd.Parameters.AddWithValue("@Email", editorEmail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateNotificationCount()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Notifications WHERE EditorEmail = @Email AND IsRead = 0";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", editorEmail);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblNotificationCount.Text = count.ToString();
                    lblNotificationCount.Visible = count > 0;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_LBUTTONDOWN = 0x0201;

            if (m.Msg == WM_LBUTTONDOWN && pnlNotifications.Visible)
            {
                Point clickedPoint = PointToClient(Cursor.Position);

                if (!pnlNotifications.Bounds.Contains(clickedPoint) &&
                    !picNotificationBell.Bounds.Contains(clickedPoint))
                {
                    pnlNotifications.Visible = false;
                }
            }

            base.WndProc(ref m);
        }

        private void LoadAssetListToGrid()
        {
            string query = @"SELECT AssetID, AssetName, AssetDescription, DateAdded, status, AssetImagePath 
                             FROM Assets WHERE EditorEmail = @Email";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Email", editorEmail);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAssets.DataSource = dt;
            }

            dgvAssets.Columns["AssetID"].Visible = false;
            dgvAssets.Columns["AssetImagePath"].Visible = false;

            dgvAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssets.RowTemplate.Height = 40;

            dgvAssets.ClearSelection();
            UpdateCardStats();
           
        }
        private void dgvAssets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAssets.Columns[e.ColumnIndex].Name == "status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Approved")
                    e.CellStyle.ForeColor = Color.Green;
                else if (status == "Rejected")
                    e.CellStyle.ForeColor = Color.Red;
                else if (status == "Pending")
                    e.CellStyle.ForeColor = Color.DarkOrange;


                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void UpdateCardStats()
        {
            int total = 0, approved = 0, rejected = 0, pending = 0;

            foreach (DataGridViewRow row in dgvAssets.Rows)
            {
                if (row.Cells["status"].Value == null) continue;

                total++;
                string status = row.Cells["status"].Value.ToString();
                if (status == "Approved") approved++;
                else if (status == "Rejected") rejected++;
                else pending++;
            }

            lblTotalAssets.Text = total.ToString();
            lblApprovedCount.Text = approved.ToString();
            lblRejectedCount.Text = rejected.ToString();
            lblPendingCount.Text = pending.ToString();
        }



        private void dgvAssets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssets.SelectedRows.Count > 0)
            {
                var row = dgvAssets.SelectedRows[0];
                string imgPath = row.Cells["AssetImagePath"].Value?.ToString();

                if (!string.IsNullOrEmpty(imgPath))
                {
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imgPath);
                    picAssetViewer.ImageLocation = File.Exists(fullPath) ? fullPath : null;
                }
                else
                {
                    picAssetViewer.Image = null;
                }
            }
        }

        private void btnAddAssetByEditor_Click(object sender, EventArgs e)
        {
            var uploadForm = new EditorUploadForm("Editor", editorEmail);
            UIHelper.LoadFormInPanel(pnlEditor, uploadForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            if (dgvAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an asset to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvAssets.SelectedRows[0];

            //  Skip if it's a new (empty) row
            if (row.IsNewRow || row.Cells["AssetID"].Value == null)
            {
                MessageBox.Show("The selected row does not contain a valid asset.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int assetId = Convert.ToInt32(row.Cells["AssetID"].Value);
            string name = row.Cells["AssetName"].Value.ToString();
            string description = row.Cells["AssetDescription"].Value.ToString();

            //  Fetch file paths from database
            string imagePath = null, modelPath = null;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT AssetImagePath, AssetFilePath 
                         FROM Assets 
                         WHERE AssetID = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", assetId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string imageRelPath = reader["AssetImagePath"].ToString();
                            string modelRelPath = reader["AssetFilePath"].ToString();

                            imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imageRelPath);
                            modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, modelRelPath);
                        }
                    }
                }
            }

            //  Load the form dynamically
            var editForm = new EditorUploadForm("Editor", editorEmail);
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;

            pnlEditor.Controls.Clear();
            pnlEditor.Controls.Add(editForm);
            editForm.Show();

            //  Populate fields and show previews
            editForm.LoadAssetForEditing(assetId, name, description, imagePath, modelPath);
        }
    }
}
