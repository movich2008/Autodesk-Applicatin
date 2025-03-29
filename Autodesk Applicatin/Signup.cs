using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Autodesk_Applicatin
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName = CapitalizeEachWord(txtFullName.Text.Trim());
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (!ValidateInputs(fullName, email, password, confirmPassword))
                return;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            bool success = await RegisterUserAsync(fullName, email, hashedPassword);

            if (success)
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Error: Could not create account. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(string fullName, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(fullName, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Full name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async Task<bool> RegisterUserAsync(string fullName, string email, string hashedPassword)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    await conn.OpenAsync();

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

                    string insertQuery = "INSERT INTO users (full_name, email, password_hash, role) VALUES (@FullName, @Email, @Password, 'Viewer')";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
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

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
            CenterTextVertically(txtFullName);
            CenterTextVertically(txtEmail);
            CenterTextVertically(txtPassword);
            CenterTextVertically(txtConfirmPassword);

            // ✅ Tooltip for full name
            toolTip1.SetToolTip(txtFullName, "Enter your full name using letters only (e.g., John Doe)");

            // ✅ Restrict typing numbers/symbols in full name
            txtFullName.KeyPress += TxtFullName_KeyPress;
        }

        // ✅ Prevent numbers/symbols while typing full name
        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                toolTip1.Show("Only letters and spaces are allowed.", txtFullName, 0, txtFullName.Height + 5, 2000);
            }
        }

        private void CenterTextVertically(TextBox textBox)
        {
            textBox.Multiline = true;
            textBox.AutoSize = false;
            textBox.Height = 30;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Padding = new Padding(5);
        }

        private string CapitalizeEachWord(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
