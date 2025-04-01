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
            this.dataGridViewAssets = new System.Windows.Forms.DataGridView();
            this.txtSearchAssets = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAssetViewer = new System.Windows.Forms.PictureBox();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.btnEditAsset = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAssets
            // 
            this.dataGridViewAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssets.Location = new System.Drawing.Point(285, 385);
            this.dataGridViewAssets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAssets.Name = "dataGridViewAssets";
            this.dataGridViewAssets.RowHeadersWidth = 62;
            this.dataGridViewAssets.Size = new System.Drawing.Size(812, 300);
            this.dataGridViewAssets.TabIndex = 0;
            this.dataGridViewAssets.SelectionChanged += new System.EventHandler(this.dataGridViewAssets_SelectionChanged);
            // 
            // txtSearchAssets
            // 
            this.txtSearchAssets.Location = new System.Drawing.Point(512, 318);
            this.txtSearchAssets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAssets.Name = "txtSearchAssets";
            this.txtSearchAssets.Size = new System.Drawing.Size(367, 26);
            this.txtSearchAssets.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kryptonBorderEdge1);
            this.panel1.Controls.Add(this.picAssetViewer);
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 287);
            this.panel1.TabIndex = 5;
            // 
            // picAssetViewer
            // 
            this.picAssetViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAssetViewer.Location = new System.Drawing.Point(0, 0);
            this.picAssetViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAssetViewer.Name = "picAssetViewer";
            this.picAssetViewer.Size = new System.Drawing.Size(334, 285);
            this.picAssetViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAssetViewer.TabIndex = 4;
            this.picAssetViewer.TabStop = false;
            this.picAssetViewer.Click += new System.EventHandler(this.picAssetViewer_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(8, 8);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(50, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 51);
            this.panel2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(532, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "⌕";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(305, 14);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(211, 26);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1162, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 37);
            this.label12.TabIndex = 11;
            this.label12.Text = "🇬🇧";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(1274, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 51);
            this.label14.TabIndex = 20;
            this.label14.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.label14.Values.Text = "Log in";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::Autodesk_Applicatin.Properties.Resources.autodesk_logo_black_transparent1;
            this.pictureBox2.Location = new System.Drawing.Point(-19, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 39);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pnlEditor
            // 
            this.pnlEditor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlEditor.Controls.Add(this.label1);
            this.pnlEditor.Controls.Add(this.btnEditAsset);
            this.pnlEditor.Controls.Add(this.panel2);
            this.pnlEditor.Controls.Add(this.panel1);
            this.pnlEditor.Controls.Add(this.txtSearchAssets);
            this.pnlEditor.Controls.Add(this.dataGridViewAssets);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(1408, 749);
            this.pnlEditor.TabIndex = 0;
            this.pnlEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditor_Paint);
            // 
            // btnEditAsset
            // 
            this.btnEditAsset.Location = new System.Drawing.Point(578, 693);
            this.btnEditAsset.Name = "btnEditAsset";
            this.btnEditAsset.Size = new System.Drawing.Size(232, 56);
            this.btnEditAsset.TabIndex = 20;
            this.btnEditAsset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEditAsset.Values.Text = "Editing existing asset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(886, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "⌕";
            // 
            // EditorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 749);
            this.Controls.Add(this.pnlEditor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorDashboard";
            this.Load += new System.EventHandler(this.EditorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssets;
        private System.Windows.Forms.TextBox txtSearchAssets;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private System.Windows.Forms.PictureBox picAssetViewer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonButton label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlEditor;
        private Krypton.Toolkit.KryptonButton btnEditAsset;
        private System.Windows.Forms.Label label1;
    }
}