using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace AutodeskApplication
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string firstName = CapitalizeEachWord(txtFirstName.Text.Trim());
            string lastName = CapitalizeEachWord(txtLastName.Text.Trim());
            string email = txtEmail.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (!ValidateInputs(firstName, lastName, email, password, confirmPassword))
                return;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            bool success = await RegisterUserAsync(firstName, lastName, email, hashedPassword);

            if (success)
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Error: Could not create account. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Both first and last names are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(firstName, @"^[A-Za-z]+$") || !Regex.IsMatch(lastName, @"^[A-Za-z]+$"))
            {
                MessageBox.Show("First and last names must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task<bool> RegisterUserAsync(string firstName, string lastName, string email, string hashedPassword)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    await conn.OpenAsync();

                    // Check if the email already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int existingUsers = Convert.ToInt32(await checkCmd.ExecuteScalarAsync());

                        if (existingUsers > 0)
                        {
                            MessageBox.Show("An account with this email already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Insert new user with status = 'Active'
                    string insertQuery = @"INSERT INTO users 
                (first_name, last_name, email, password_hash, role, status) 
                VALUES (@FirstName, @LastName, @Email, @Password, 'Viewer', 'Active')";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void Signup_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
            UIHelper.CenterTextVertically(txtFirstName);
            UIHelper.CenterTextVertically(txtLastName);
            UIHelper.CenterTextVertically(txtEmail);
            UIHelper.CenterTextVertically(txtPassword);
            UIHelper.CenterTextVertically(txtConfirmPassword);

            toolTip1.SetToolTip(txtFirstName, "Enter your first name (letters only)");
            toolTip1.SetToolTip(txtLastName, "Enter your last name (letters only)");

            txtFirstName.KeyPress += TxtName_KeyPress;
            txtLastName.KeyPress += TxtName_KeyPress;
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Control textBox = sender as Control;
                toolTip1.Show("Only letters are allowed.", textBox, 0, textBox.Height + 5, 2000);
            }
        }

        private string CapitalizeEachWord(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        public static void LogUserActivity(string userTag, string email, string role, string activityType)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO UserActivity (UserTag, Email, Role, ActivityType) " +
                               "VALUES (@UserTag, @Email, @Role, @ActivityType)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserTag", userTag);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@ActivityType", activityType);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void linkLogin_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
