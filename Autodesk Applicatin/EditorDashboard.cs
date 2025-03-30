using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class EditorDashboard : Form
    {
        private string role;

        public EditorDashboard(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void EditorDashboard_Load(object sender, EventArgs e)
        {
            LoadAssetListToGrid();
            UIStyleHelper.StyleAllControls(this);
        }

        private void LoadAssetListToGrid()
        {
            string query = "SELECT AssetID, AssetName, AssetDescription, AssetImagePath, AssetFilePath, DateAdded FROM Assets";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAssets.DataSource = dt;
            }

            // Hide AssetID column if exists
            if (dataGridViewAssets.Columns.Contains("AssetID"))
                dataGridViewAssets.Columns["AssetID"].Visible = false;

            dataGridViewAssets.ClearSelection();
        }

        private void dataGridViewAssets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAssets.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewAssets.SelectedRows[0];

                if (row.Cells["AssetImagePath"]?.Value != null)
                {
                    string imagePath = row.Cells["AssetImagePath"].Value.ToString();
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

                    if (File.Exists(fullPath))
                        picAssetViewer.ImageLocation = fullPath;
                    else
                        picAssetViewer.Image = null;
                }
                else
                {
                    picAssetViewer.Image = null;
                }
            }
        }

        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an asset to edit.");
                return;
            }

            DataGridViewRow row = dataGridViewAssets.SelectedRows[0];

            int assetId = Convert.ToInt32(row.Cells["AssetID"].Value);
            string name = row.Cells["AssetName"].Value.ToString();
            string description = row.Cells["AssetDescription"].Value.ToString();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, row.Cells["AssetImagePath"].Value.ToString());
            string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, row.Cells["AssetFilePath"].Value.ToString());

            var form = new EditorUploadForm("Editor");
            form.LoadAssetForEditing(assetId, name, description, imagePath, modelPath);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAssetListToGrid(); // Reload list after successful edit
            }
        }

        private void pnlEditor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
