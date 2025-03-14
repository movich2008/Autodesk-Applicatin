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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e) { 
        
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void txtbxLogInHere_Click(object sender, EventArgs e)
        {
            LoginForm txtbxLogInHere = new LoginForm();
            txtbxLogInHere.Show();
            this.Hide();
        }
    }
}
