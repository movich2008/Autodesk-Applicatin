namespace AutodeskApplication
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
            this.lblAssetName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl2dFilePath = new System.Windows.Forms.Label();
            this.lblAssetDescription = new System.Windows.Forms.Label();
            this.lbl3dFilePath = new System.Windows.Forms.Label();
            this.picAssetViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(487, 111);
            this.lblAssetName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(35, 13);
            this.lblAssetName.TabIndex = 18;
            this.lblAssetName.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(487, 173);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "label3";
            // 
            // lbl2dFilePath
            // 
            this.lbl2dFilePath.AutoSize = true;
            this.lbl2dFilePath.Location = new System.Drawing.Point(487, 284);
            this.lbl2dFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2dFilePath.Name = "lbl2dFilePath";
            this.lbl2dFilePath.Size = new System.Drawing.Size(35, 13);
            this.lbl2dFilePath.TabIndex = 20;
            this.lbl2dFilePath.Text = "label4";
            // 
            // lblAssetDescription
            // 
            this.lblAssetDescription.AutoSize = true;
            this.lblAssetDescription.Location = new System.Drawing.Point(487, 231);
            this.lblAssetDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssetDescription.Name = "lblAssetDescription";
            this.lblAssetDescription.Size = new System.Drawing.Size(35, 13);
            this.lblAssetDescription.TabIndex = 21;
            this.lblAssetDescription.Text = "label5";
            // 
            // lbl3dFilePath
            // 
            this.lbl3dFilePath.AutoSize = true;
            this.lbl3dFilePath.Location = new System.Drawing.Point(487, 342);
            this.lbl3dFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3dFilePath.Name = "lbl3dFilePath";
            this.lbl3dFilePath.Size = new System.Drawing.Size(35, 13);
            this.lbl3dFilePath.TabIndex = 22;
            this.lbl3dFilePath.Text = "label6";
            // 
            // picAssetViewer
            // 
            this.picAssetViewer.Location = new System.Drawing.Point(93, 111);
            this.picAssetViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAssetViewer.Name = "picAssetViewer";
            this.picAssetViewer.Size = new System.Drawing.Size(285, 254);
            this.picAssetViewer.TabIndex = 23;
            this.picAssetViewer.TabStop = false;
            // 
            // AssetDetailsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(809, 561);
            this.Controls.Add(this.picAssetViewer);
            this.Controls.Add(this.lbl3dFilePath);
            this.Controls.Add(this.lblAssetDescription);
            this.Controls.Add(this.lbl2dFilePath);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAssetName);
            this.MinimumSize = new System.Drawing.Size(798, 394);
            this.Name = "AssetDetailsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetDetailsPopup";
            this.Load += new System.EventHandler(this.AssetDetailsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblAssetName;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lbl2dFilePath;
        public System.Windows.Forms.Label lblAssetDescription;
        public System.Windows.Forms.Label lbl3dFilePath;
        public System.Windows.Forms.PictureBox picAssetViewer;
    }
}