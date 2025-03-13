using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string userName = txtbxUsername.Text;
            string password = txtbxpassword.Text;
            if (string.IsNullOrWhiteSpace(userName) || (string.IsNullOrWhiteSpace(password)))
            {
                MessageBox.Show("Invalid Email or Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }

        private void LinkLableCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signUp = new Signup();
            signUp.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
