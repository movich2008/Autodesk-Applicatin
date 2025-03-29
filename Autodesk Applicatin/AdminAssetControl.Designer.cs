namespace Autodesk_Applicatin
{
    partial class AdminAssetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnUploadAsset = new System.Windows.Forms.Button();
            this.flowAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.btnUploadAsset);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(678, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnUploadAsset
            // 
            this.btnUploadAsset.Location = new System.Drawing.Point(550, 10);
            this.btnUploadAsset.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnUploadAsset.Name = "btnUploadAsset";
            this.btnUploadAsset.Size = new System.Drawing.Size(89, 35);
            this.btnUploadAsset.TabIndex = 0;
            this.btnUploadAsset.Text = "Upload Asset";
            this.btnUploadAsset.UseVisualStyleBackColor = true;
            this.btnUploadAsset.Click += new System.EventHandler(this.btnUploadAsset_Click);
            // 
            // flowAssets
            // 
            this.flowAssets.AutoScroll = true;
            this.flowAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowAssets.Location = new System.Drawing.Point(0, 60);
            this.flowAssets.Name = "flowAssets";
            this.flowAssets.Size = new System.Drawing.Size(678, 470);
            this.flowAssets.TabIndex = 1;
            // 
            // AdminAssetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowAssets);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "AdminAssetControl";
            this.Size = new System.Drawing.Size(678, 530);
            this.Load += new System.EventHandler(this.AdminAssetControl_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnUploadAsset;
        private System.Windows.Forms.FlowLayoutPanel flowAssets;
    }
}
