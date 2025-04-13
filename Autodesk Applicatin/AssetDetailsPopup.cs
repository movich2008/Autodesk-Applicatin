using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;


namespace Autodesk_Applicatin
{
    public partial class AssetDetailsPopup : Form
    {
        public AssetDetailsPopup()
        {
            InitializeComponent();
        }

        private void AssetDetailsPopup_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
