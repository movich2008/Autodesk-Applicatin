using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace AutodeskApplication
{
    public partial class AdminAssetDetails : Form
    {
        public AdminAssetDetails(string assetName, string description, string modelPath, string imagePath, DateTime dateAdded)
        {
            InitializeComponent();

            lblAssetName.Text = assetName;
            lblAdminDescription.Text = description;
            lblAdminModelType.Text = Path.GetExtension(modelPath)?.ToLower() ?? "N/A";
            lblAdminImageType.Text = Path.GetExtension(imagePath)?.ToLower() ?? "N/A";
            lblAdminDate.Text = dateAdded.ToString("MMM dd, yyyy hh:mm tt");

            if (File.Exists(imagePath))
            {
                picAdminAssetPreview.Image = Image.FromFile(imagePath);
            }
            else
            {
                picAdminAssetPreview.Image = SystemIcons.Warning.ToBitmap();
            }
        }
    }
}