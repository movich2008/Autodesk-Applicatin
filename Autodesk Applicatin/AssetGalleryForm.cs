using System;
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
