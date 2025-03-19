using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Drawing;


namespace Autodesk_Applicatin
{
    public partial class Signup : Form
    {
        string connString = "Server=127.0.0.1;Port=3307;Database=AutodeskAssetsDB;User ID=root;Password=05032023Ak#;SslMode=None;AllowPublicKeyRetrieval=True;";

        public Signup()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Validate inputs
            if (!ValidateInputs(email, password, confirmPassword))
                return;

            // Hash password before storing in the database
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string testHash = BCrypt.Net.BCrypt.HashPassword("test123");
            Console.WriteLine(testHash);


            // Store the user in the database
            bool success = await RegisterUserAsync(email, hashedPassword);

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

        private bool ValidateInputs(string email, string password, string confirmPassword)
        {
            // Email validation
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password validation
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Confirm password check
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task<bool> RegisterUserAsync(string email, string hashedPassword)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();

                    // Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        object result = await checkCmd.ExecuteScalarAsync();
                        int existingUsers = Convert.ToInt32(result ?? 0);

                        if (existingUsers > 0)
                        {
                            MessageBox.Show("An account with this email already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO users (email, password_hash, role) VALUES (@Email, @Password, 'viewer')";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
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

            CenterTextVertically(txtEmail);
            CenterTextVertically(txtPassword);
            CenterTextVertically(txtConfirmPassword);

        }

        private void CenterTextVertically(TextBox textBox)
        {
            // Move cursor to center (forces text to align in the middle)
            textBox.Multiline = true;
            textBox.AutoSize = false;
            textBox.Height = 30;  
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Padding = new Padding(5); 
        }

    }
}
