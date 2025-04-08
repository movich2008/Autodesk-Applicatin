using System.Collections.Generic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;

namespace Autodesk_Applicatin
{
    public static class UIHelper
    {
        public static void LoadFormInPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        public static void CenterTextVertically(Control textBox)
        {
            if (textBox is TextBox txt)
            {
                txt.Multiline = true;
                txt.AutoSize = false;
                txt.Height = 30;
                txt.TextAlign = HorizontalAlignment.Center;
                txt.Padding = new Padding(5); // Optional: adds left/right spacing
            }
            else if (textBox is KryptonTextBox ktxt)
            {
                ktxt.Multiline = true;
                ktxt.TextAlign = HorizontalAlignment.Left; // or Center if you want
                ktxt.StateCommon.Content.Padding = new Padding(5, 6, 5, 6); // top/bottom padding
                ktxt.StateCommon.Border.Rounding = 10;
                ktxt.StateCommon.Back.Color1 = Color.White;
                ktxt.StateCommon.Border.Color1 = Color.LightGray;
            }
        }




        // ✅ Add this method to populate AssetDetailsPopup
        public static void PopulateAssetDetails(
            AssetDetailsPopup popup,
            string name,
            string description,
            string date,
            string ext2D,
            string ext3D,
            Image image)
        {
            popup.lblAssetName.Text = "Asset Name: " + name;
            popup.lblAssetDescription.Text = "Description: " + description;
            popup.lblDate.Text = "Date Modified: " + date;
            popup.lbl2dFilePath.Text = "2D File Type: " + ext2D;
            popup.lbl3dFilePath.Text = "3D File Type: " + ext3D;

            if (image != null)
            {
                popup.picAssetViewer.Image = image;
                popup.picAssetViewer.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                popup.picAssetViewer.Image = null;
            }
        }

        public static void PopulateAssetGallery(AssetGalleryForm galleryForm, List<int> assetIDs, Func<int, string> getName, Func<int, string> getImage, Action<int> openAssetCallback)
        {
            galleryForm.flpAssets.Controls.Clear();

            foreach (int assetID in assetIDs)
            {
                string name = getName(assetID);
                string imagePath = getImage(assetID);
                string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

                // 📦 Card panel
                Panel card = new Panel();
                card.Width = 350;
                card.Height = 270;
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;

                // 🖼 Thumbnail
                PictureBox pic = new PictureBox();
                pic.Width = 180;
                pic.Height = 150;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.ImageLocation = File.Exists(fullImagePath) ? fullImagePath : null;
                pic.Left = (card.Width - pic.Width) / 2;
                pic.Top = 10;
              

                // 🏷 Label
                Label lbl = new Label();
                lbl.Text = name;
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Width = 180;
                lbl.Height = 20;
                lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lbl.Left = (card.Width - lbl.Width) / 2;
                lbl.Top = pic.Bottom + 5; lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                // 🔘 Button
                Button btn = new Button();
                btn.Text = "Open";
                UIStyleHelper.StyleButton(btn); // Apply your shared styling
                btn.Left = (card.Width - btn.Width) / 2;
                btn.Top = lbl.Bottom + 10;
                btn.Click += (s, e) =>
                {
                    galleryForm.Close(); // Close gallery
                    openAssetCallback(assetID); // Load asset
                };

                // 🧩 Add to card
                card.Controls.Add(pic);
                card.Controls.Add(lbl);
                card.Controls.Add(btn);

                // Add to flow panel
                galleryForm.flpAssets.Controls.Add(card);
            }
        }
    }
    
}