using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AutodeskApplication.Utilities;
using BCrypt.Net;

namespace AutodeskApplication
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
            if (!cmbUserRole.Items.Contains("Editor"))
                cmbUserRole.Items.Add("Editor");
            if (!cmbUserRole.Items.Contains("Manager"))
                cmbUserRole.Items.Add("Manager");

            cmbUserRole.SelectedIndex = 0;

            UIStyleHelper.StyleAllControls(this);
            toolTip1.SetToolTip(txtFirstName, "Enter first name (letters only)");
            toolTip1.SetToolTip(txtLastName, "Enter last name (letters only)");

            txtFirstName.KeyPress += TxtName_KeyPress;
            txtLastName.KeyPress += TxtName_KeyPress;
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("Only letters and spaces are allowed", (Control)sender, 0, 25, 2000);
            }
        }

        public void LoadUserForEditing(string email, string role, string status)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Close form and return to ManageUsersControl
                return;
            }

            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot edit another Admin user.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close form and return to ManageUsersControl
                return;
            }

            isEditMode = true;
            originalEmail = email;

            txtEmail.Text = email;
            txtEmail.Enabled = false;
            cmbUserRole.SelectedItem = role;
            btnSaveUser.Text = "Update User";

            txtPassword.Enabled = false;
            txtPassword.Text = "••••••••";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT first_name, last_name FROM users WHERE email = @Email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["first_name"].ToString();
                            txtLastName.Text = reader["last_name"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = CapitalizeEachWord(txtFirstName.Text.Trim());
                string lastName = CapitalizeEachWord(txtLastName.Text.Trim());
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string role = cmbUserRole.SelectedItem?.ToString()?.Trim();

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
                {
                    ShowMessage("Please fill in all fields.", false);
                    return;
                }

                if (!isEditMode)
                {
                    if (password.Length < 6)
                    {
                        ShowMessage("Password must be at least 6 characters long.", false);
                        return;
                    }

                    if (!password.Any(char.IsDigit))
                    {
                        ShowMessage("Password must include at least one number.", false);
                        return;
                    }

                    if (!password.Any(char.IsUpper))
                    {
                        ShowMessage("Password must include at least one uppercase letter.", false);
                        return;
                    }
                }

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (isEditMode)
                    {
                        string updateQuery = "UPDATE users SET first_name = @FirstName, last_name = @LastName, role = @Role WHERE email = @OriginalEmail";
                        using (var cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@Role", role);
                            cmd.Parameters.AddWithValue("@OriginalEmail", originalEmail);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            ShowMessage(rowsAffected > 0 ? "User updated successfully!" : "No changes made.", true);
                        }
                    }
                    else
                    {
                        var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @Email", conn);
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            ShowMessage("A user with this email already exists.", false);
                            return;
                        }

                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                        string initials = firstName.Substring(0, 1).ToUpper() + lastName.Substring(0, 1).ToUpper();
                        string userTag = initials + new Random().Next(100, 999);

                        string insertQuery = "INSERT INTO users (first_name, last_name, email, password_hash, role, status, user_tag) " +
                                             "VALUES (@FirstName, @LastName, @Email, @Password, @Role, 'Active', @UserTag)";

                        using (var cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", hashedPassword);
                            cmd.Parameters.AddWithValue("@Role", role);
                            cmd.Parameters.AddWithValue("@UserTag", userTag);

                            cmd.ExecuteNonQuery();
                            ShowMessage($"{role} account created successfully!\nTag: {userTag}", true);
                        }
                    }
                }

                Control parentControl = this.Parent;
                while (parentControl != null && !(parentControl is ManageUsersControl))
                    parentControl = parentControl.Parent;

                if (parentControl is ManageUsersControl manageUsers)
                    manageUsers.LoadUsers();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowMessage(string message, bool isSuccess)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblMessage.Visible = true;
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtEmail.Enabled = true;
            txtPassword.Clear();
            txtPassword.Enabled = true;
            if (cmbUserRole.Items.Count > 0)
                cmbUserRole.SelectedIndex = 0;
            btnSaveUser.Text = "Create User";
            isEditMode = false;
        }

        private string CapitalizeEachWord(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
