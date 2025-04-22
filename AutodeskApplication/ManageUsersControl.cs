using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutodeskApplication
{
    public partial class ManageUsersControl : UserControl
    {
        public ManageUsersControl()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            cmbUserFilter.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            cmbRoleOrActivityFilter.SelectedIndex = 0;
            LoadUsers();
            LoadUserActivity();
            LoadViewerActivity();
        }

        public void LoadUsers()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, user_tag, first_name, last_name, email, role, status, created_at FROM users";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;

                   
                    dgvUsers.ClearSelection();
                    StyleStatusColumn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }


        private void LoadUserActivity()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM UserActivity ORDER BY Timestamp DESC";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUserActivity.DataSource = dt;
                    dgvUserActivity.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user activity: " + ex.Message);
            }
        }

        private void LoadViewerActivity()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM ViewerActivity ORDER BY ViewedAt DESC";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvViewerActivity.DataSource = dt;
                    dgvViewerActivity.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading viewer activity: " + ex.Message);
            }
        }

        private void StyleStatusColumn()
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                string status = row.Cells["status"].Value?.ToString();
                if (status == "Active")
                    row.Cells["status"].Style.ForeColor = Color.Green;
                else if (status == "Deactivated")
                    row.Cells["status"].Style.ForeColor = Color.Red;
            }
        }

        private void UpdateUserStatus(int userId, string status)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE users SET status = @Status WHERE id = @UserID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadUsers();
                MessageBox.Show(status == "Active" ? "User reactivated successfully." : "User deactivated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void DeleteUser(int userId)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE id = @UserID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadUsers();
                MessageBox.Show("User deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUsers.ClearSelection();
                dgvUsers.Rows[e.RowIndex].Selected = true;

                var row = dgvUsers.Rows[e.RowIndex];
                string status = row.Cells["status"].Value?.ToString();
                int userId = Convert.ToInt32(row.Cells["id"].Value);

                userContextMenu.Items.Clear();
                userContextMenu.Items.Add("Delete").Click += (s, ev) =>
                {
                    if (status == "Active")
                    {
                        MessageBox.Show("Cannot delete an active user. Please deactivate first.");
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteUser(userId);
                    }
                };

                userContextMenu.Show(Cursor.Position);
            }
        }

        private void dgvUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Columns[e.ColumnIndex].Name == "status")
            {
                var row = dgvUsers.Rows[e.RowIndex];
        string newStatus = row.Cells["status"].Value?.ToString();
        int userId = Convert.ToInt32(row.Cells["id"].Value);

        // Prompt confirmation
        DialogResult result = MessageBox.Show($"Are you sure you want to {newStatus.ToLower()} this user?",
                                               "Confirm Status Change",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateUserStatus(userId, newStatus);
    }
                else
                {
                    // Revert back to original value by reloading users (since we don't store previous value)
                    LoadUsers();
}
            }
        }


        private void dgvUsers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvUsers.CurrentCell.ColumnIndex == dgvUsers.Columns["status"].Index && e.Control is ComboBox combo)
            {
                combo.DropDownStyle = ComboBoxStyle.DropDownList;

                // Remove previous handler (avoid duplication)
                combo.SelectedIndexChanged -= StatusComboBox_SelectedIndexChanged;
                combo.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            }
        }
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentCell != null &&
                dgvUsers.CurrentCell.ColumnIndex == dgvUsers.Columns["status"].Index &&
                dgvUsers.CurrentRow != null)
            {
                string selectedStatus = (sender as ComboBox)?.SelectedItem?.ToString();
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);
                string currentStatus = dgvUsers.CurrentRow.Cells["status"].Value?.ToString();

                if (selectedStatus != currentStatus)
                {
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to change status to '{selectedStatus}'?",
                        "Confirm Status Change",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        UpdateUserStatus(userId, selectedStatus);
                        LoadUsers(); // Refresh to reflect the latest
                    }
                    else
                    {
                        // Revert back if canceled
                        dgvUsers.CurrentRow.Cells["status"].Value = currentStatus;
                    }
                }
            }
        }




        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvUsers.DataSource == null) return;
            string keyword = txtSearch.Text.Trim().ToLower();
            dgvUsers.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvUsers.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.IsNewRow) continue;
                string fullName = ($"{row.Cells["first_name"].Value} {row.Cells["last_name"].Value}").ToLower();
                string email = row.Cells["email"].Value?.ToString().ToLower();
                string tag = row.Cells["user_tag"].Value?.ToString().ToLower();
                row.Visible = fullName.Contains(keyword) || (email?.Contains(keyword) ?? false) || (tag?.Contains(keyword) ?? false);
            }

            cm.ResumeBinding();
        }

        private void cmbUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvUsers.DataSource == null) return;
            string selected = cmbUserFilter.SelectedItem?.ToString().ToLower();
            dgvUsers.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvUsers.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.IsNewRow) continue;
                string role = row.Cells["role"].Value?.ToString().ToLower();
                string status = row.Cells["status"].Value?.ToString().ToLower();
                row.Visible = selected == "all" || role == selected || status == selected;
            }

            cm.ResumeBinding();
        }

        private void txtSearchActivity_TextChanged(object sender, EventArgs e)
        {
            if (dgvViewerActivity.DataSource == null) return;
            string keyword = txtSearchActivity.Text.Trim().ToLower();
            dgvViewerActivity.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvViewerActivity.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvViewerActivity.Rows)
            {
                if (row.IsNewRow) continue;
                string email = row.Cells["ViewerEmail"].Value?.ToString().ToLower();
                row.Visible = email?.Contains(keyword) ?? false;
            }

            cm.ResumeBinding();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvViewerActivity.DataSource == null) return;
            string selected = cmbFilter.SelectedItem?.ToString().ToLower();
            dgvViewerActivity.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvViewerActivity.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvViewerActivity.Rows)
            {
                if (row.IsNewRow) continue;
                bool show = selected == "all";
                if (!show && DateTime.TryParse(row.Cells["ViewedAt"].Value?.ToString(), out DateTime viewedAt))
                {
                    if (selected == "today")
                        show = viewedAt.Date == DateTime.Today;
                    else if (selected == "this week")
                    {
                        var startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                        show = viewedAt.Date >= startOfWeek && viewedAt.Date <= DateTime.Today;
                    }
                    else if (selected == "this month")
                        show = viewedAt.Month == DateTime.Today.Month && viewedAt.Year == DateTime.Today.Year;
                }
                row.Visible = show;
            }

            cm.ResumeBinding();
        }

        private void txtSearchUserActivity_TextChanged(object sender, EventArgs e)
        {
            if (dgvUserActivity.DataSource == null) return;
            string keyword = txtSearchUserActivity.Text.Trim().ToLower();
            dgvUserActivity.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvUserActivity.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvUserActivity.Rows)
            {
                if (row.IsNewRow) continue;
                string email = row.Cells["Email"].Value?.ToString().ToLower();
                row.Visible = email?.Contains(keyword) ?? false;
            }

            cm.ResumeBinding();
        }

        private void cmbRoleOrActivityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvUserActivity.DataSource == null) return;
            string selected = cmbRoleOrActivityFilter.SelectedItem?.ToString().ToLower();
            dgvUserActivity.ClearSelection();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvUserActivity.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvUserActivity.Rows)
            {
                if (row.IsNewRow) continue;
                string role = row.Cells["Role"].Value?.ToString().ToLower();
                string activity = row.Cells["ActivityType"].Value?.ToString().ToLower();
                row.Visible = selected == "all" || role == selected || activity == selected;
            }

            cm.ResumeBinding();
        }

        
        private void dgvUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUsers.IsCurrentCellDirty)
                dgvUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Initialize the form
            var createForm = new UserCreationForm();

            // Optional: Dock or show it within a panel (if you're embedding)
            createForm.TopLevel = false;
            createForm.FormBorderStyle = FormBorderStyle.None;
            createForm.Dock = DockStyle.Fill;

            // Assuming you have a Panel named pnlMainContent to hold this form
            pnlUserFormContainer.Controls.Clear();
            pnlUserFormContainer.Controls.Add(createForm);

            createForm.Show();

            // Defer any layout changes for dgvUsers after it's reloaded
            this.BeginInvoke(new Action(() =>
            {
                dgvUsers.ClearSelection();
                StyleStatusColumn(); // This method should set color styling
            }));
        }


        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0 || dgvUsers.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select a valid user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvUsers.SelectedRows[0];
            string role = selectedRow.Cells["role"].Value?.ToString();
            string email = selectedRow.Cells["email"].Value?.ToString();
            string status = selectedRow.Cells["status"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(email) || role.Equals("Admin", StringComparison.OrdinalIgnoreCase) || role.Equals("Viewer", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot edit an Admin or Viewer user.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ Always create a fresh new instance before showing
            UserCreationForm userForm = new UserCreationForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            pnlUserFormContainer.Controls.Clear(); // Assuming you are loading inside a panel
            pnlUserFormContainer.Controls.Add(userForm);
            userForm.BringToFront();
            userForm.Show();

            userForm.LoadUserForEditing(email, role, status);
        }



        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleStatusColumn();
        }

        private void dgvUsers_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dgvUsers.IsCurrentCellDirty)
                dgvUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void ManageUsersControl_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                // Safe UI updates after DataGridView is fully loaded
                dgvUsers.AutoResizeColumns();
                dgvUsers.ClearSelection();
            }));
        }

    }
}
