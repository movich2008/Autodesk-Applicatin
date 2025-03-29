namespace Autodesk_Applicatin
{
    partial class Admin3DViewer
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.elementHost3D = new System.Windows.Forms.Integration.ElementHost();
            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.pnlTopBar, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.elementHost3D, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(660, 495);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.btnViewDetails);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopBar.Location = new System.Drawing.Point(3, 3);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(654, 39);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetails.Location = new System.Drawing.Point(476, 3);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 30);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "View Asset Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // elementHost3D
            // 
            this.elementHost3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3D.Location = new System.Drawing.Point(3, 48);
            this.elementHost3D.Name = "elementHost3D";
            this.elementHost3D.Size = new System.Drawing.Size(654, 444);
            this.elementHost3D.TabIndex = 1;
            this.elementHost3D.Text = "elementHost";
            this.elementHost3D.Child = null;
            // 
            // Admin3DViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Admin3DViewer";
            this.Size = new System.Drawing.Size(660, 495);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Integration.ElementHost elementHost3D;
    }
}
