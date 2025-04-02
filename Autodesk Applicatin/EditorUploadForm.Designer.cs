namespace Autodesk_Applicatin
{
    partial class EditorUploadForm
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
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.elementHost3D = new System.Windows.Forms.Integration.ElementHost();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3dPreviewPath = new System.Windows.Forms.Label();
            this.lbl2dPreviewPath = new System.Windows.Forms.Label();
            this.picAssetPreview = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSelect2D = new System.Windows.Forms.Button();
            this.btnSelect3D = new System.Windows.Forms.Button();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetPreview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpload
            // 
            this.pnlUpload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpload.Controls.Add(this.textBox1);
            this.pnlUpload.Controls.Add(this.panel2);
            this.pnlUpload.Controls.Add(this.elementHost3D);
            this.pnlUpload.Controls.Add(this.label2);
            this.pnlUpload.Controls.Add(this.label1);
            this.pnlUpload.Controls.Add(this.lbl3dPreviewPath);
            this.pnlUpload.Controls.Add(this.lbl2dPreviewPath);
            this.pnlUpload.Controls.Add(this.picAssetPreview);
            this.pnlUpload.Controls.Add(this.btnUpload);
            this.pnlUpload.Controls.Add(this.btnSelect2D);
            this.pnlUpload.Controls.Add(this.btnSelect3D);
            this.pnlUpload.Controls.Add(this.txtAssetName);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpload.Location = new System.Drawing.Point(0, 0);
            this.pnlUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(1480, 912);
            this.pnlUpload.TabIndex = 0;
            // 
            // elementHost3D
            // 
            this.elementHost3D.Location = new System.Drawing.Point(943, 178);
            this.elementHost3D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elementHost3D.Name = "elementHost3D";
            this.elementHost3D.Size = new System.Drawing.Size(496, 380);
            this.elementHost3D.TabIndex = 3;
            this.elementHost3D.Text = "elementHost";
            this.elementHost3D.Child = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = " Asset Name:";
            // 
            // lbl3dPreviewPath
            // 
            this.lbl3dPreviewPath.AutoSize = true;
            this.lbl3dPreviewPath.Location = new System.Drawing.Point(138, 635);
            this.lbl3dPreviewPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3dPreviewPath.Name = "lbl3dPreviewPath";
            this.lbl3dPreviewPath.Size = new System.Drawing.Size(89, 20);
            this.lbl3dPreviewPath.TabIndex = 4;
            this.lbl3dPreviewPath.Text = "Model Path";
            // 
            // lbl2dPreviewPath
            // 
            this.lbl2dPreviewPath.AutoSize = true;
            this.lbl2dPreviewPath.Location = new System.Drawing.Point(901, 635);
            this.lbl2dPreviewPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2dPreviewPath.Name = "lbl2dPreviewPath";
            this.lbl2dPreviewPath.Size = new System.Drawing.Size(91, 20);
            this.lbl2dPreviewPath.TabIndex = 3;
            this.lbl2dPreviewPath.Text = "Image Path";
            // 
            // picAssetPreview
            // 
            this.picAssetPreview.Location = new System.Drawing.Point(122, 178);
            this.picAssetPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAssetPreview.Name = "picAssetPreview";
            this.picAssetPreview.Size = new System.Drawing.Size(496, 380);
            this.picAssetPreview.TabIndex = 2;
            this.picAssetPreview.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpload.Location = new System.Drawing.Point(496, 832);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(496, 52);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnSelect2D
            // 
            this.btnSelect2D.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect2D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect2D.Location = new System.Drawing.Point(160, 692);
            this.btnSelect2D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect2D.Name = "btnSelect2D";
            this.btnSelect2D.Size = new System.Drawing.Size(496, 40);
            this.btnSelect2D.TabIndex = 1;
            this.btnSelect2D.Text = "Browse 2D";
            this.btnSelect2D.UseVisualStyleBackColor = false;
            this.btnSelect2D.Click += new System.EventHandler(this.btnSelect2D_Click_1);
            // 
            // btnSelect3D
            // 
            this.btnSelect3D.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect3D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect3D.Location = new System.Drawing.Point(915, 692);
            this.btnSelect3D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect3D.Name = "btnSelect3D";
            this.btnSelect3D.Size = new System.Drawing.Size(496, 40);
            this.btnSelect3D.TabIndex = 1;
            this.btnSelect3D.Text = "Browse 3D";
            this.btnSelect3D.UseVisualStyleBackColor = false;
            this.btnSelect3D.Click += new System.EventHandler(this.btnSelect3D_Click_1);
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(124, 118);
            this.txtAssetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(494, 26);
            this.txtAssetName.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1485, 77);
            this.panel2.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(1322, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 51);
            this.label14.TabIndex = 21;
            this.label14.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.label14.Values.Text = "Log in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Editor Upload Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Autodesk_Applicatin.Properties.Resources.autodesk_logo_black_transparent1;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 39);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1248, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 37);
            this.label12.TabIndex = 11;
            this.label12.Text = "🇬🇧";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(293, 19);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(238, 26);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(551, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "⌕";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(945, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 26);
            this.textBox1.TabIndex = 18;
            // 
            // EditorUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 912);
            this.Controls.Add(this.pnlUpload);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditorUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorDashboard";
            this.Load += new System.EventHandler(this.EditorUploadForm_Load);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetPreview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Integration.ElementHost elementHost3D;
        private System.Windows.Forms.PictureBox picAssetPreview;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSelect2D;
        private System.Windows.Forms.Button btnSelect3D;
        private System.Windows.Forms.Label lbl2dPreviewPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl3dPreviewPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonButton label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}