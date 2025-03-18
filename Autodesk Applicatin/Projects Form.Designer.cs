namespace Autodesk_Applicatin
{
    partial class Projects_Form : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aUTODESKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelApproved = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTODESKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aUTODESKToolStripMenuItem
            // 
            this.aUTODESKToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aUTODESKToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aUTODESKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aUTODESKToolStripMenuItem.Name = "aUTODESKToolStripMenuItem";
            this.aUTODESKToolStripMenuItem.Size = new System.Drawing.Size(202, 49);
            this.aUTODESKToolStripMenuItem.Text = "AUTODESK";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileType,
            this.Date,
            this.FileSize});
            this.dataGridView1.Location = new System.Drawing.Point(443, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(860, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 8;
            this.FileName.Name = "FileName";
            this.FileName.Width = 150;
            // 
            // FileType
            // 
            this.FileType.HeaderText = "FileType";
            this.FileType.MinimumWidth = 8;
            this.FileType.Name = "FileType";
            this.FileType.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "FileSize";
            this.FileSize.MinimumWidth = 8;
            this.FileSize.Name = "FileSize";
            this.FileSize.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnModel);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnUpdates);
            this.panel1.Controls.Add(this.btnApproved);
            this.panel1.Controls.Add(this.btnRecent);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 504);
            this.panel1.TabIndex = 3;
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModel.Location = new System.Drawing.Point(66, 283);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(127, 43);
            this.btnModel.TabIndex = 9;
            this.btnModel.Text = "Model Updates";
            this.btnModel.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUser.Location = new System.Drawing.Point(66, 221);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(127, 28);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "User Activity";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdates
            // 
            this.btnUpdates.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdates.Location = new System.Drawing.Point(66, 168);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(137, 32);
            this.btnUpdates.TabIndex = 7;
            this.btnUpdates.Text = "Updates/Reports";
            this.btnUpdates.UseVisualStyleBackColor = false;
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnApproved.Location = new System.Drawing.Point(66, 115);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(127, 31);
            this.btnApproved.TabIndex = 6;
            this.btnApproved.Text = "Approved items";
            this.btnApproved.UseVisualStyleBackColor = false;
            // 
            // btnRecent
            // 
            this.btnRecent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRecent.Location = new System.Drawing.Point(66, 54);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(127, 36);
            this.btnRecent.TabIndex = 5;
            this.btnRecent.Text = "Recent Activity";
            this.btnRecent.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDashboard.Location = new System.Drawing.Point(66, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(103, 36);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelData.Controls.Add(this.pictureBox2);
            this.panelData.Controls.Add(this.textBox1);
            this.panelData.Controls.Add(this.picturebox1);
            this.panelData.Controls.Add(this.comboBox1);
            this.panelData.Controls.Add(this.labelApproved);
            this.panelData.Location = new System.Drawing.Point(0, 56);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1340, 92);
            this.panelData.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1094, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Denied"});
            this.comboBox1.Location = new System.Drawing.Point(724, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // labelApproved
            // 
            this.labelApproved.AutoSize = true;
            this.labelApproved.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApproved.Location = new System.Drawing.Point(97, 28);
            this.labelApproved.Name = "labelApproved";
            this.labelApproved.Size = new System.Drawing.Size(252, 37);
            this.labelApproved.TabIndex = 0;
            this.labelApproved.Text = "Approved States";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Autodesk_Applicatin.Properties.Resources.file;
            this.pictureBox2.Location = new System.Drawing.Point(66, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 40);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // picturebox1
            // 
            this.picturebox1.Image = global::Autodesk_Applicatin.Properties.Resources.search1;
            this.picturebox1.Location = new System.Drawing.Point(1056, 41);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(32, 26);
            this.picturebox1.TabIndex = 3;
            this.picturebox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Autodesk_Applicatin.Properties.Resources.diploma;
            this.pictureBox8.Location = new System.Drawing.Point(12, 286);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 40);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Autodesk_Applicatin.Properties.Resources.users_alt;
            this.pictureBox7.Location = new System.Drawing.Point(12, 221);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 40);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Autodesk_Applicatin.Properties.Resources.stats;
            this.pictureBox6.Location = new System.Drawing.Point(12, 160);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 40);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Autodesk_Applicatin.Properties.Resources.check;
            this.pictureBox5.Location = new System.Drawing.Point(12, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 40);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Autodesk_Applicatin.Properties.Resources.time_past;
            this.pictureBox4.Location = new System.Drawing.Point(12, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 36);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Autodesk_Applicatin.Properties.Resources.home;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Projects_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 727);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Projects_Form";
            this.Text = "Projects_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aUTODESKToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelApproved;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}