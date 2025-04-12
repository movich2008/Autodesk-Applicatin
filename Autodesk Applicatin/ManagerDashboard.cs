using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Autodesk_Applicatin
{
    public partial class ManagerDashboard : Form
    {
        private readonly string userRole;
        private readonly string managerEmail;
        private string previousStatus = "";
        private ComboBox statusComboBox = null;

        public ManagerDashboard(string role, string email)
        {
            InitializeComponent();
            userRole = role;
            managerEmail = email;
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            if (userRole.ToLower() != "manager" && userRole.ToLower() != "admin")
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied");
                this.Close();
                return;
            }

            UIStyleHelper.StyleAllControls(this);

            cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "Approved", "Rejected" });
            cmbStatusFilter.SelectedIndex = 0;

            LoadAssets("All");
            UpdateCardStats();

            dgvAssets.CellBeginEdit += DgvAssets_CellBeginEdit;
            dgvAssets.EditingControlShowing += DgvAssets_EditingControlShowing;
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

        private void DgvAssets_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAssets.Columns[e.ColumnIndex].Name == "status")
            {
                previousStatus = dgvAssets.Rows[e.RowIndex].Cells["status"].Value?.ToString();
            }
        }

        private void DgvAssets_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAssets.CurrentCell.ColumnIndex == dgvAssets.Columns["status"].Index && e.Control is ComboBox)
            {
                if (statusComboBox != null)
                    statusComboBox.SelectedIndexChanged -= StatusComboBox_SelectedIndexChanged;

                statusComboBox = (ComboBox)e.Control;
                statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAssets.CurrentRow == null)
                return;

            var combo = sender as ComboBox;
            string newStatus = combo?.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus)) return;

            DataGridViewRow row = dgvAssets.CurrentRow;
            int assetID = Convert.ToInt32(row.Cells["AssetID"].Value);
            string editorEmail = row.Cells["EditorEmail"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(editorEmail))
            {
                MessageBox.Show("Editor email not found for this asset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newStatus == previousStatus) return;

            if (newStatus == "Rejected")
            {
                var noteForm = new RejectionNoteForm(assetID, editorEmail, managerEmail);
                if (noteForm.ShowDialog() == DialogResult.OK)
                    this.BeginInvoke(new Action(() => LoadAssets(cmbStatusFilter.SelectedItem.ToString())));
                else
                    row.Cells["status"].Value = previousStatus;
            }
            else
            {
                string message = newStatus == "Approved"
                    ? $"Your asset #{assetID} has been approved."
                    : "";

                UpdateAssetStatusWithNote(assetID, newStatus, message, editorEmail);
                this.BeginInvoke(new Action(() => LoadAssets(cmbStatusFilter.SelectedItem.ToString())));
            }
        }

        private void LoadAssets(string filterStatus = "Pending")
        {
            string query = @"SELECT AssetID, AssetName, AssetDescription, DateAdded, status, 
                             status_updated_by, status_updated_at, EditorEmail FROM Assets";

            if (!string.IsNullOrEmpty(filterStatus) && filterStatus != "All")
                query += " WHERE status = @status";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (filterStatus != "All")
                        cmd.Parameters.AddWithValue("@status", filterStatus);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvAssets.DataSource = table;

                    int columnCount = dgvAssets.Columns.Count;
                    if (columnCount > 0)
                    {
                        int totalWidth = dgvAssets.ClientSize.Width;
                        int equalWidth = totalWidth / columnCount;

                        foreach (DataGridViewColumn col in dgvAssets.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            col.Width = equalWidth;
                        }
                    }

                    ConvertStatusColumnToComboBox();
                    UpdateCardStats();
                }
            }
        }

        private void ConvertStatusColumnToComboBox()
        {
            if (dgvAssets.Columns.Contains("status") && !(dgvAssets.Columns["status"] is DataGridViewComboBoxColumn))
            {
                int index = dgvAssets.Columns["status"].Index;
                dgvAssets.Columns.Remove("status");

                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "status",
                    HeaderText = "Status",
                    DataPropertyName = "status",
                    DataSource = new[] { "Pending", "Approved", "Rejected" },
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                };

                dgvAssets.Columns.Insert(index, combo);
            }
        }

        private void UpdateAssetStatusWithNote(int assetID, string newStatus, string message, string editorEmail)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string updateQuery = @"UPDATE Assets 
                                       SET status = @status, 
                                           status_updated_by = @updatedBy, 
                                           status_updated_at = @updatedAt 
                                       WHERE AssetID = @assetID";

                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@updatedBy", managerEmail);
                    cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@assetID", assetID);
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrEmpty(message))
                {
                    string insertNote = @"INSERT INTO Notifications 
                                          (AssetID, EditorEmail, Message, IsRead, CreatedAt) 
                                          VALUES (@assetID, @editorEmail, @message, 0, NOW())";

                    using (var cmd = new MySqlCommand(insertNote, conn))
                    {
                        cmd.Parameters.AddWithValue("@assetID", assetID);
                        cmd.Parameters.AddWithValue("@editorEmail", editorEmail);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void ApplyCombinedFilter()
        {
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            string searchTerm = txtSearch.Text.Trim();

            string query = @"SELECT AssetID, AssetName, AssetDescription, DateAdded, status, 
                             status_updated_by, status_updated_at, EditorEmail FROM Assets WHERE 1=1";

            if (status != "All")
                query += " AND status = @status";

            if (!string.IsNullOrEmpty(searchTerm))
                query += " AND LOWER(AssetName) LIKE @search";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (status != "All")
                        cmd.Parameters.AddWithValue("@status", status);

                    if (!string.IsNullOrEmpty(searchTerm))
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm.ToLower()}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvAssets.DataSource = table;

                    int columnCount = dgvAssets.Columns.Count;
                    if (columnCount > 0)
                    {
                        int totalWidth = dgvAssets.ClientSize.Width;
                        int equalWidth = totalWidth / columnCount;

                        foreach (DataGridViewColumn col in dgvAssets.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            col.Width = equalWidth;
                        }
                    }

                    ConvertStatusColumnToComboBox();
                    UpdateCardStats();
                }
            }
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilter();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
