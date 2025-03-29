namespace Autodesk_Applicatin
{
    partial class ViewerDashboard
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
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.panel3D = new System.Windows.Forms.Panel();
            this.btnAssetDetails = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnViewAssets = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.pnlNavbar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.Gray;
            this.pnlNavbar.Controls.Add(this.panel3D);
            this.pnlNavbar.Controls.Add(this.btnAssetDetails);
            this.pnlNavbar.Controls.Add(this.pnlContent);
            this.pnlNavbar.Controls.Add(this.btnViewAssets);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(867, 50);
            this.pnlNavbar.TabIndex = 0;
            // 
            // panel3D
            // 
            this.panel3D.Location = new System.Drawing.Point(0, 55);
            this.panel3D.Name = "panel3D";
            this.panel3D.Size = new System.Drawing.Size(440, 403);
            this.panel3D.TabIndex = 3;
            // 
            // btnAssetDetails
            // 
            this.btnAssetDetails.BackColor = System.Drawing.Color.Gray;
            this.btnAssetDetails.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAssetDetails.FlatAppearance.BorderSize = 0;
            this.btnAssetDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssetDetails.Location = new System.Drawing.Point(654, 12);
            this.btnAssetDetails.Name = "btnAssetDetails";
            this.btnAssetDetails.Size = new System.Drawing.Size(107, 29);
            this.btnAssetDetails.TabIndex = 0;
            this.btnAssetDetails.Text = "Asset Details";
            this.btnAssetDetails.UseVisualStyleBackColor = false;
            this.btnAssetDetails.Click += new System.EventHandler(this.btnAssetDetails_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Silver;
            this.pnlContent.Location = new System.Drawing.Point(0, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(437, 350);
            this.pnlContent.TabIndex = 1;
            // 
            // btnViewAssets
            // 
            this.btnViewAssets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewAssets.Location = new System.Drawing.Point(137, 12);
            this.btnViewAssets.Name = "btnViewAssets";
            this.btnViewAssets.Size = new System.Drawing.Size(107, 29);
            this.btnViewAssets.TabIndex = 0;
            this.btnViewAssets.Text = "View Assets";
            this.btnViewAssets.UseVisualStyleBackColor = true;
            this.btnViewAssets.Click += new System.EventHandler(this.btnViewAssets_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.tableLayoutPanel1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 50);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(867, 355);
            this.pnlMainContent.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.35289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.6338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.098592F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 355);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewDetails);
            this.panel1.Controls.Add(this.elementHost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 293);
            this.panel1.TabIndex = 0;
            // 
            // elementHost
            // 
            this.elementHost.BackColor = System.Drawing.Color.White;
            this.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost.Location = new System.Drawing.Point(0, 0);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(855, 291);
            this.elementHost.TabIndex = 15;
            this.elementHost.Child = null;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetails.Location = new System.Drawing.Point(367, 128);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(120, 34);
            this.btnViewDetails.TabIndex = 20;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // ViewerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(867, 405);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlNavbar);
            this.Name = "ViewerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewerDashboard";
            this.Load += new System.EventHandler(this.ViewerDashboard_Load_1);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnViewAssets;
        private System.Windows.Forms.Button btnAssetDetails;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel3D;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private System.Windows.Forms.Button btnViewDetails;
        //private System.Windows.Forms.PictureBox picAssetViewer;
        //private System.Windows.Forms.Panel pnlAssetDetails;
        //private System.Windows.Forms.Label lblDate;
        //private System.Windows.Forms.Label lbl3dFilePath;
        //private System.Windows.Forms.Label lbl2dFilePath;
        //private System.Windows.Forms.Label lblAssetDescription;
        //private System.Windows.Forms.Label lblAssetName;
    }
}