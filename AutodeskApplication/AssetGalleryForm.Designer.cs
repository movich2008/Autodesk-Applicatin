namespace AutodeskApplication
{
    partial class AssetGalleryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpAsset = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flpAsset
            // 
            this.flpAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAsset.Location = new System.Drawing.Point(0, 0);
            this.flpAsset.Name = "flpAsset";
            this.flpAsset.Size = new System.Drawing.Size(843, 497);
            this.flpAsset.TabIndex = 0;
            // 
            // AssetGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(843, 497);
            this.Controls.Add(this.flpAsset);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssetGalleryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel flpAsset;
    }
}