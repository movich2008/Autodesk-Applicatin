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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSelect2D = new System.Windows.Forms.Button();
            this.btnSelect3D = new System.Windows.Forms.Button();
            this.txtAssetDescription = new System.Windows.Forms.TextBox();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picAssetPreview = new System.Windows.Forms.PictureBox();
            this.pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpload
            // 
            this.pnlUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpload.Controls.Add(this.elementHost3D);
            this.pnlUpload.Controls.Add(this.label2);
            this.pnlUpload.Controls.Add(this.label1);
            this.pnlUpload.Controls.Add(this.lbl3dPreviewPath);
            this.pnlUpload.Controls.Add(this.lbl2dPreviewPath);
            this.pnlUpload.Controls.Add(this.picAssetPreview);
            this.pnlUpload.Controls.Add(this.btnUpload);
            this.pnlUpload.Controls.Add(this.btnSelect2D);
            this.pnlUpload.Controls.Add(this.btnSelect3D);
            this.pnlUpload.Controls.Add(this.txtAssetDescription);
            this.pnlUpload.Controls.Add(this.txtAssetName);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpload.Location = new System.Drawing.Point(0, 0);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(1293, 891);
            this.pnlUpload.TabIndex = 0;
            // 
            // elementHost3D
            // 
            this.elementHost3D.Location = new System.Drawing.Point(693, 149);
            this.elementHost3D.Name = "elementHost3D";
            this.elementHost3D.Size = new System.Drawing.Size(331, 247);
            this.elementHost3D.TabIndex = 3;
            this.elementHost3D.Text = "elementHost";
            this.elementHost3D.Child = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Asset Name:";
            // 
            // lbl3dPreviewPath
            // 
            this.lbl3dPreviewPath.AutoSize = true;
            this.lbl3dPreviewPath.Location = new System.Drawing.Point(131, 422);
            this.lbl3dPreviewPath.Name = "lbl3dPreviewPath";
            this.lbl3dPreviewPath.Size = new System.Drawing.Size(61, 13);
            this.lbl3dPreviewPath.TabIndex = 4;
            this.lbl3dPreviewPath.Text = "Model Path";
            // 
            // lbl2dPreviewPath
            // 
            this.lbl2dPreviewPath.AutoSize = true;
            this.lbl2dPreviewPath.Location = new System.Drawing.Point(690, 422);
            this.lbl2dPreviewPath.Name = "lbl2dPreviewPath";
            this.lbl2dPreviewPath.Size = new System.Drawing.Size(61, 13);
            this.lbl2dPreviewPath.TabIndex = 3;
            this.lbl2dPreviewPath.Text = "Image Path";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(420, 518);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(331, 34);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnSelect2D
            // 
            this.btnSelect2D.Location = new System.Drawing.Point(134, 450);
            this.btnSelect2D.Name = "btnSelect2D";
            this.btnSelect2D.Size = new System.Drawing.Size(331, 26);
            this.btnSelect2D.TabIndex = 1;
            this.btnSelect2D.Text = "Browse 2D";
            this.btnSelect2D.UseVisualStyleBackColor = true;
            this.btnSelect2D.Click += new System.EventHandler(this.btnSelect2D_Click_1);
            // 
            // btnSelect3D
            // 
            this.btnSelect3D.Location = new System.Drawing.Point(693, 450);
            this.btnSelect3D.Name = "btnSelect3D";
            this.btnSelect3D.Size = new System.Drawing.Size(331, 26);
            this.btnSelect3D.TabIndex = 1;
            this.btnSelect3D.Text = "Browse 3D";
            this.btnSelect3D.UseVisualStyleBackColor = true;
            this.btnSelect3D.Click += new System.EventHandler(this.btnSelect3D_Click_1);
            // 
            // txtAssetDescription
            // 
            this.txtAssetDescription.Location = new System.Drawing.Point(693, 55);
            this.txtAssetDescription.Multiline = true;
            this.txtAssetDescription.Name = "txtAssetDescription";
            this.txtAssetDescription.Size = new System.Drawing.Size(331, 29);
            this.txtAssetDescription.TabIndex = 0;
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(134, 55);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(331, 20);
            this.txtAssetName.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // picAssetPreview
            // 
            this.picAssetPreview.Location = new System.Drawing.Point(134, 149);
            this.picAssetPreview.Name = "picAssetPreview";
            this.picAssetPreview.Size = new System.Drawing.Size(331, 247);
            this.picAssetPreview.TabIndex = 2;
            this.picAssetPreview.TabStop = false;
            // 
            // EditorUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 891);
            this.Controls.Add(this.pnlUpload);
            this.Name = "EditorUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorDashboard";
            this.Load += new System.EventHandler(this.EditorUploadForm_Load);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.TextBox txtAssetDescription;
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
    }
}