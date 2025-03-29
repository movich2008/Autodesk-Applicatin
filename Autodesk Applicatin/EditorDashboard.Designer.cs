namespace Autodesk_Applicatin
{
    partial class EditorDashboard
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
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.dataGridViewAssets = new System.Windows.Forms.DataGridView();
            this.btnEditAsset = new System.Windows.Forms.Button();
            this.txtSearchAssets = new System.Windows.Forms.TextBox();
            this.picAssetViewer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditor
            // 
            this.pnlEditor.Controls.Add(this.panel1);
            this.pnlEditor.Controls.Add(this.txtSearchAssets);
            this.pnlEditor.Controls.Add(this.btnEditAsset);
            this.pnlEditor.Controls.Add(this.dataGridViewAssets);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(585, 487);
            this.pnlEditor.TabIndex = 0;
            // 
            // dataGridViewAssets
            // 
            this.dataGridViewAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssets.Location = new System.Drawing.Point(21, 205);
            this.dataGridViewAssets.Name = "dataGridViewAssets";
            this.dataGridViewAssets.Size = new System.Drawing.Size(541, 195);
            this.dataGridViewAssets.TabIndex = 0;
            this.dataGridViewAssets.SelectionChanged += new System.EventHandler(this.dataGridViewAssets_SelectionChanged);
            // 
            // btnEditAsset
            // 
            this.btnEditAsset.Location = new System.Drawing.Point(187, 422);
            this.btnEditAsset.Name = "btnEditAsset";
            this.btnEditAsset.Size = new System.Drawing.Size(220, 37);
            this.btnEditAsset.TabIndex = 2;
            this.btnEditAsset.Text = "Edit Existing Asset";
            this.btnEditAsset.UseVisualStyleBackColor = true;
            this.btnEditAsset.Click += new System.EventHandler(this.btnEditAsset_Click);
            // 
            // txtSearchAssets
            // 
            this.txtSearchAssets.Location = new System.Drawing.Point(316, 12);
            this.txtSearchAssets.Name = "txtSearchAssets";
            this.txtSearchAssets.Size = new System.Drawing.Size(246, 20);
            this.txtSearchAssets.TabIndex = 3;
            // 
            // picAssetViewer
            // 
            this.picAssetViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAssetViewer.Location = new System.Drawing.Point(0, 0);
            this.picAssetViewer.Name = "picAssetViewer";
            this.picAssetViewer.Size = new System.Drawing.Size(223, 185);
            this.picAssetViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAssetViewer.TabIndex = 4;
            this.picAssetViewer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picAssetViewer);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 187);
            this.panel1.TabIndex = 5;
            // 
            // EditorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 487);
            this.Controls.Add(this.pnlEditor);
            this.Name = "EditorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorDashboard";
            this.Load += new System.EventHandler(this.EditorDashboard_Load);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.DataGridView dataGridViewAssets;
        private System.Windows.Forms.TextBox txtSearchAssets;
        private System.Windows.Forms.Button btnEditAsset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAssetViewer;
    }
}