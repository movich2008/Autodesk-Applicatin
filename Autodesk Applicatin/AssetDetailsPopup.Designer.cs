namespace Autodesk_Applicatin
{
    partial class AssetDetailsPopup
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
            this.picAssetViewer = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl3dFilePath = new System.Windows.Forms.Label();
            this.lbl2dFilePath = new System.Windows.Forms.Label();
            this.lblAssetDescription = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAssetViewer
            // 
            this.picAssetViewer.BackColor = System.Drawing.SystemColors.Control;
            this.picAssetViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAssetViewer.Location = new System.Drawing.Point(0, 0);
            this.picAssetViewer.Name = "picAssetViewer";
            this.picAssetViewer.Size = new System.Drawing.Size(517, 481);
            this.picAssetViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAssetViewer.TabIndex = 0;
            this.picAssetViewer.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDate.Location = new System.Drawing.Point(23, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date modified";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lbl3dFilePath
            // 
            this.lbl3dFilePath.AutoSize = true;
            this.lbl3dFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl3dFilePath.Location = new System.Drawing.Point(23, 209);
            this.lbl3dFilePath.Name = "lbl3dFilePath";
            this.lbl3dFilePath.Size = new System.Drawing.Size(68, 13);
            this.lbl3dFilePath.TabIndex = 3;
            this.lbl3dFilePath.Text = "3D File Path";
            this.lbl3dFilePath.Click += new System.EventHandler(this.lbl3dFilePath_Click);
            // 
            // lbl2dFilePath
            // 
            this.lbl2dFilePath.AutoSize = true;
            this.lbl2dFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl2dFilePath.Location = new System.Drawing.Point(23, 159);
            this.lbl2dFilePath.Name = "lbl2dFilePath";
            this.lbl2dFilePath.Size = new System.Drawing.Size(68, 13);
            this.lbl2dFilePath.TabIndex = 4;
            this.lbl2dFilePath.Text = "2D File Path";
            this.lbl2dFilePath.Click += new System.EventHandler(this.lbl2dFilePath_Click);
            // 
            // lblAssetDescription
            // 
            this.lblAssetDescription.AutoSize = true;
            this.lblAssetDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAssetDescription.Location = new System.Drawing.Point(24, 104);
            this.lblAssetDescription.Name = "lblAssetDescription";
            this.lblAssetDescription.Size = new System.Drawing.Size(66, 13);
            this.lblAssetDescription.TabIndex = 5;
            this.lblAssetDescription.Text = "Description";
            this.lblAssetDescription.Click += new System.EventHandler(this.lblAssetDescription_Click);
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAssetName.Location = new System.Drawing.Point(24, 59);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(65, 13);
            this.lblAssetName.TabIndex = 6;
            this.lblAssetName.Text = "Asset name";
            this.lblAssetName.Click += new System.EventHandler(this.lblAssetName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picAssetViewer);
            this.panel1.Location = new System.Drawing.Point(47, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 481);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblAssetName);
            this.panel2.Controls.Add(this.lblAssetDescription);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lbl2dFilePath);
            this.panel2.Controls.Add(this.lbl3dFilePath);
            this.panel2.Location = new System.Drawing.Point(667, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 489);
            this.panel2.TabIndex = 8;
            // 
            // AssetDetailsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1120, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "AssetDetailsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetDetailsPopup";
            this.Load += new System.EventHandler(this.AssetDetailsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picAssetViewer;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lbl3dFilePath;
        public System.Windows.Forms.Label lbl2dFilePath;
        public System.Windows.Forms.Label lblAssetDescription;
        public System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}