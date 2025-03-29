using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Autodesk_Applicatin
{
    public partial class UserCreationForm : Form
    {
        private bool isEditMode = false;
        private string originalEmail = "";

        public UserCreationForm()
        {
            InitializeComponent();
        }

        private void UserCreationForm_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.AddRange(new[] { "Editor", "Manager" });
            cmbUserRole.SelectedIndex = 0;

            cmbStatus.Items.AddRange(new[] { "Active", "Deactivated" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.Visible = false;

            UIStyleHelper.StyleAllControls(this);
            toolTip1.SetToolTip(txtFullName, "Enter your full name (letters and spaces only)");
            txtFullName.KeyPress += TxtFullName_KeyPress;
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("Only letters and spaces are allowed", txtFullName, 0, txtFullName.Height + 5, 2000);
            }
        }

        public void LoadUserForEditing(string email, string role, string status)
        {
            isEditMode = true;
            originalEmail = email;

            txtEmail.Text = email;
            txtEmail.Enabled = false;
            cmbUserRole.SelectedItem = role;
            cmbStatus.SelectedItem = status;
            cmbStatus.Visible = true;
            btnSaveUser.Text = "Update User";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT full_name FROM users WHERE email = @Email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    txtFullName.Text = result?.ToString() ?? "";
                }
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = CapitalizeEachWord(txtFullName.Text.Trim());
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string role = cmbUserRole.SelectedItem?.ToString()?.Trim();
                string status = cmbStatus.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
                {
                    lblMessage.Text = "Please fill in all fields.";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                    return;
                }

                if (password.Length < 6)
                {
                    lblMessage.Text = "Password must be at least 6 characters long.";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                    return;
                }

                if (!password.Any(char.IsDigit))
                {
                    lblMessage.Text = "Password must include at least one number.";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                    return;
                }

                if (!password.Any(char.IsUpper))
                {
                    lblMessage.Text = "Password must include at least one uppercase letter.";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                    return;
                }

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (isEditMode)
                    {
                        string updateQuery = "UPDATE Users SET full_name = @FullName, role = @Role, status = @Status WHERE email = @OriginalEmail";
                        using (var cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", fullName);
                            cmd.Parameters.AddWithValue("@Role", role);
                            cmd.Parameters.AddWithValue("@Status", status);
                            cmd.Parameters.AddWithValue("@OriginalEmail", originalEmail);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            lblMessage.Text = rowsAffected > 0 ? "User updated successfully!" : "No changes made.";
                            lblMessage.ForeColor = Color.Green;
                            lblMessage.Visible = true;
                        }
                    }
                    else
                    {
                        var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM Users WHERE email = @Email", conn);
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            lblMessage.Text = "A user with this email already exists.";
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Visible = true;
                            return;
                        }

                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                        string insertQuery = "INSERT INTO Users (full_name, email, password_hash, role, status) " +
                                             "VALUES (@FullName, @Email, @Password, @Role, 'Active')";

                        using (var cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", fullName);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", hashedPassword);
                            cmd.Parameters.AddWithValue("@Role", role);
                            cmd.ExecuteNonQuery();

                            lblMessage.Text = $"{role} account created successfully!";
                            lblMessage.ForeColor = Color.Green;
                            lblMessage.Visible = true;
                        }
                    }
                }

                // 🌀 Refresh parent view
                Control parentControl = this.Parent;
                while (parentControl != null && !(parentControl is ManageUsersControl))
                {
                    parentControl = parentControl.Parent;
                }

                if (parentControl is ManageUsersControl manageUsers)
                {
                    manageUsers.LoadUsers(); // 🔁 Call refresh method
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtEmail.Enabled = true;
            txtPassword.Clear();
            cmbUserRole.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbStatus.Visible = false;
            btnSaveUser.Text = "Create User";
            isEditMode = false;
        }

        private string CapitalizeEachWord(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}