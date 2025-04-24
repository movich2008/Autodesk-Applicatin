using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace AutodeskApplication
{
    public static class UIHelper
    {
        // Dynamically load a Form into a panel (used in dashboards)
        public static void LoadFormInPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        // Apply consistent padding, borders, and rounding to Krypton or standard TextBox
        public static void CenterTextVertically(Control control)
        {
            if (control is TextBox txt)
            {
                txt.Multiline = true;
                txt.AutoSize = false;
                txt.Height = 30;
                txt.TextAlign = HorizontalAlignment.Left;
                txt.Padding = new Padding(5);
                txt.BackColor = Color.White;
            }
            else if (control is KryptonTextBox ktxt)
            {
                //ktxt.Multiline = true;
                //ktxt.TextAlign = HorizontalAlignment.Left;

                //ktxt.StateCommon.Content.Padding = new Padding(8, 5, 8, 5);
                //ktxt.StateCommon.Content.Font = new Font("Segoe UI", 10);
                //ktxt.StateCommon.Content.Color1 = Color.Black;

                //ktxt.StateCommon.Back.Color1 = Color.White;
                //ktxt.StateCommon.Border.Color1 = Color.SteelBlue;
                //ktxt.StateCommon.Border.Rounding = 10;
                //ktxt.StateCommon.Border.Width = 1;
                //ktxt.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                ktxt.Multiline = false;
                ktxt.TextAlign = HorizontalAlignment.Left;

                ktxt.StateCommon.Content.Font = new Font("Segoe UI", 10);
                ktxt.StateCommon.Content.Color1 = Color.Black;
                ktxt.StateCommon.Content.Padding = new Padding(6, 5, 6, 5);

                ktxt.StateCommon.Back.Color1 = Color.White;

                ktxt.StateCommon.Border.Color1 = Color.LightGray;
                ktxt.StateCommon.Border.Rounding = 10;
                ktxt.StateCommon.Border.Width = 1;
            }
        }

        // Populate asset detail labels and image (e.g., in popup)
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
           
    
           
            

            if (image != null)
            {
               
            }
            else
            {
                
            }
        }

        // Populate a FlowLayoutPanel with thumbnail-style cards
        public static void PopulateAssetGallery(
            AssetGalleryForm galleryForm,
            List<int> assetIDs,
            Func<int, string> getName,
            Func<int, string> getImage,
            Action<int> openAssetCallback)
        {
            galleryForm.flpAsset.Controls.Clear();

            foreach (int assetID in assetIDs)
            {
                string name = getName(assetID);
                string imagePath = getImage(assetID);
                string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

                Panel card = new Panel
                {
                    Width = 350,
                    Height = 270,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pic = new PictureBox
                {
                    Width = 180,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = File.Exists(fullImagePath) ? fullImagePath : null,
                    Left = (card.Width - 180) / 2,
                    Top = 10
                };

                Label lbl = new Label
                {
                    Text = name,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 180,
                    Height = 20,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Left = (card.Width - 180) / 2,
                    Top = pic.Bottom + 5
                };

                Button btn = new Button
                {
                    Text = "Open"
                };
                UIStyleHelper.StyleButton(btn);
                btn.Left = (card.Width - btn.Width) / 2;
                btn.Top = lbl.Bottom + 10;
                btn.Click += (s, e) =>
                {
                    galleryForm.Close();
                    openAssetCallback(assetID);
                };

                card.Controls.Add(pic);
                card.Controls.Add(lbl);
                card.Controls.Add(btn);

                galleryForm.flpAsset.Controls.Add(card);
            }
        }
    }
}
