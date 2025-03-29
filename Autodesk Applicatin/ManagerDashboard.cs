using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class ManagerDashboard : Form
    {
        private readonly string userRole;

        public ManagerDashboard(string role)
        {
            InitializeComponent();
            userRole = role;
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
            cmbStatusFilter.SelectedIndex = 1;

            LoadAssets(); // Load assets initially
            dgvAssets.CellValueChanged += dgvAssets_CellValueChanged;
        }

        private void LoadAssets(string filterStatus = "Pending")
        {
            string query = @"SELECT AssetID, AssetName, AssetDescription, DateAdded, status, status_updated_by, status_updated_at 
                             FROM Assets";

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

                    ConvertStatusColumnToComboBox();
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
                    DataPropertyName = "status",
                    HeaderText = "Status",
                    DataSource = new[] { "Pending", "Approved", "Rejected" },
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                };

                dgvAssets.Columns.Insert(index, combo);
            }
        }

        private void dgvAssets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAssets.Columns[e.ColumnIndex].Name == "status")
            {
                DataGridViewRow row = dgvAssets.Rows[e.RowIndex];

                if (row.Cells["AssetID"].Value == null || row.Cells["status"].Value == null)
                    return;

                int assetID = Convert.ToInt32(row.Cells["AssetID"].Value);
                string newStatus = row.Cells["status"].Value.ToString();

                UpdateAssetStatus(assetID, newStatus);
            }
        }

        private void UpdateAssetStatus(int assetID, string newStatus)
        {
            string query = @"UPDATE Assets 
                             SET status = @status, 
                                 status_updated_by = @updatedBy, 
                                 status_updated_at = CURRENT_TIMESTAMP 
                             WHERE AssetID = @assetID";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@updatedBy", userRole); // ✅ Or replace with email if needed
                    cmd.Parameters.AddWithValue("@assetID", assetID);
                    cmd.ExecuteNonQuery();
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

        private void ApplyCombinedFilter()
        {
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            string searchTerm = txtSearch.Text.Trim();

            string query = @"SELECT AssetID, AssetName, AssetDescription, DateAdded, status, status_updated_by, status_updated_at 
                             FROM Assets WHERE 1=1";

            if (status != "All")
                query += " AND status = @status";

            if (!string.IsNullOrEmpty(searchTerm))
                query += " AND AssetName LIKE @search";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (status != "All")
                        cmd.Parameters.AddWithValue("@status", status);

                    if (!string.IsNullOrEmpty(searchTerm))
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvAssets.DataSource = table;

                    ConvertStatusColumnToComboBox();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
