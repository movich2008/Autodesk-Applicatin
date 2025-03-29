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
    public partial class AssetGalleryForm : Form
    {
        public AssetGalleryForm()
        {
            InitializeComponent();
        }

        private void AssetGalleryForm_Load(object sender, EventArgs e)
        {
            UIStyleHelper.StyleAllControls(this);
        }
    }
}
