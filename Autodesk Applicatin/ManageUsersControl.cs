using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class ManageUsersControl : UserControl
    {
        private UserCreationForm userFormInstance;
        private bool isContextMenuInitialized = false;

        public ManageUsersControl()
        {
            InitializeComponent();
        }

        private void ManageUsersControl_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
            LoadUsers();
            SetupContextMenu(); // Right-click menu for Deactivate/Delete
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (userFormInstance == null || userFormInstance.IsDisposed)
            {
                userFormInstance = new UserCreationForm();
                userFormInstance.TopLevel = false;
                userFormInstance.FormBorderStyle = FormBorderStyle.None;
                userFormInstance.Dock = DockStyle.Fill;

                pnlUserFormContainer.Controls.Clear();
                pnlUserFormContainer.Controls.Add(userFormInstance);
                userFormInstance.Show();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            DataGridViewRow row = dgvUsers.SelectedRows[0];
            string email = row.Cells["Email"].Value?.ToString();
            string role = row.Cells["Role"].Value?.ToString();
            string status = row.Cells["Status"].Value?.ToString();

            UserCreationForm form = new UserCreationForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            form.LoadUserForEditing(email, role, status);

            pnlUserFormContainer.Controls.Clear();
            pnlUserFormContainer.Controls.Add(form);
            form.Show();
        }

        public void LoadUsers()
        {
            dgvUsers.Rows.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT id, full_name, email, role, status, created_at FROM Users", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rowIndex = dgvUsers.Rows.Add();
                    dgvUsers.Rows[rowIndex].Cells["ID"].Value = reader["id"].ToString();
                    dgvUsers.Rows[rowIndex].Cells["FullName"].Value = reader["full_name"].ToString(); // ✅ New!
                    dgvUsers.Rows[rowIndex].Cells["Email"].Value = reader["email"].ToString();
                    dgvUsers.Rows[rowIndex].Cells["Role"].Value = reader["role"].ToString();
                    dgvUsers.Rows[rowIndex].Cells["Status"].Value = reader["status"].ToString();
                    dgvUsers.Rows[rowIndex].Cells["CreatedAt"].Value = Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm");
                }
            }
        }


        private void SetupContextMenu()
        {
            if (isContextMenuInitialized) return;

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Deactivate");
            contextMenu.Items.Add("Delete");

            contextMenu.ItemClicked += contextMenuUsers_ItemClicked;
            dgvUsers.ContextMenuStrip = contextMenu;

            isContextMenuInitialized = true;
        }

        private void contextMenuUsers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            string selectedEmail = dgvUsers.SelectedRows[0].Cells["Email"].Value?.ToString();

            if (e.ClickedItem.Text == "Deactivate")
            {
                UpdateUserStatus(selectedEmail, "Deactivated");
            }
            else if (e.ClickedItem.Text == "Delete")
            {
                if (MessageBox.Show("Are you sure to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteUser(selectedEmail);
                }
            }

            LoadUsers(); // Refresh
        }

        private void UpdateUserStatus(string email, string newStatus)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE Users SET Status = @status WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteUser(string email)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM Users WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterUsers(txtSearch.Text.Trim().ToLower());
        }

        private void FilterUsers(string keyword)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.IsNewRow) continue;

                string fullName = row.Cells["FullName"].Value?.ToString().ToLower() ?? "";
                string email = row.Cells["Email"].Value?.ToString().ToLower() ?? "";
                string role = row.Cells["Role"].Value?.ToString().ToLower() ?? "";

                // Show row if any of the values contain the search keyword
                row.Visible = fullName.Contains(keyword) || email.Contains(keyword) || role.Contains(keyword);
            }
        }

    }
}
