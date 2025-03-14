using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk_Application;


namespace Autodesk_Applicatin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataHelper datahelper = new DataHelper();
            string userName = txtbxUsername.Text;
            string password = txtbxpassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Invalid Username or Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check credentials using DataHelper
            if (datahelper.ValidateLogin(userName, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LinkLableCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signUp = new Signup();
            signUp.Show();
            this.Hide();
        }

        //private void LoginForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void txtbxUsername_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
