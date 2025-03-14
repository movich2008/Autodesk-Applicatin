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
  
    public partial class ModelDetails : Form
    {

        public ModelDetails()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbxSaveDetails_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Model model = new Model
            {
                ModelName = txtBoxFirstName.Text,
                Description = textBox2.Text,
                FileFormat = textBox3.Text,
                CreatedOn = dtpCreatedOn.Value,
                ModifiedOn = dtpModifiedOn.Value, 
                Dimensions = textBox6.Text,
                ImagePath = picBxPreview.ImageLocation 
            };

        }

        private void txtxbxUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; //Can be changed as clients demand

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picBxPreview.Image = Image.FromFile(openFileDialog.FileName);


                    picBxPreview.ImageLocation = openFileDialog.FileName;
                }
            }
        }
    }

    //Model class

    public class Model
    {
        public string ModelName { get; set; }
        public string Description { get; set; }
        public string FileFormat { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Dimensions { get; set; }
        public string ImagePath { get; set; }
    }
}
