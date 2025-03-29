namespace Autodesk_Applicatin
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
            this.flpAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpAssets
            // 
            this.flpAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAssets.Location = new System.Drawing.Point(0, 0);
            this.flpAssets.Name = "flpAssets";
            this.flpAssets.Size = new System.Drawing.Size(800, 450);
            this.flpAssets.TabIndex = 0;
            // 
            // AssetGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpAssets);
            this.Name = "AssetGalleryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "AssetGalleryForm";
            this.Load += new System.EventHandler(this.AssetGalleryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpAssets;
    }
}