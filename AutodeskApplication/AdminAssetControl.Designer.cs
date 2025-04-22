namespace AutodeskApplication
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
            this.flowAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowAssets
            // 
            this.flowAssets.AutoScroll = true;
            this.flowAssets.BackColor = System.Drawing.Color.White;
            this.flowAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowAssets.Location = new System.Drawing.Point(0, 0);
            this.flowAssets.Name = "flowAssets";
            this.flowAssets.Size = new System.Drawing.Size(678, 530);
            this.flowAssets.TabIndex = 1;
            // 
            // AdminAssetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowAssets);
            this.Name = "AdminAssetControl";
            this.Size = new System.Drawing.Size(678, 530);
            this.Load += new System.EventHandler(this.AdminAssetControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowAssets;
    }
}
