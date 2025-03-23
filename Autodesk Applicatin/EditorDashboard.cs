using System;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public partial class EditorDashboard : Form
    {
        private string userRole;

        public EditorDashboard(string role) // ✅ Accept role
        {
            InitializeComponent();
            userRole = role; // ✅ Store role
        }
    }
}