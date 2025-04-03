namespace Autodesk_Applicatin
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnViewAssets;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewAssets = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(64, 124);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 32);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Gray;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.button2);
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Controls.Add(this.btnManageUsers);
            this.pnlSidebar.Controls.Add(this.btnViewAssets);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(291, 903);
            this.pnlSidebar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(15, 488);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(15, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(15, 803);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 62);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.Location = new System.Drawing.Point(15, 274);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(240, 62);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewAssets
            // 
            this.btnViewAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAssets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewAssets.Location = new System.Drawing.Point(15, 184);
            this.btnViewAssets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewAssets.Name = "btnViewAssets";
            this.btnViewAssets.Size = new System.Drawing.Size(240, 62);
            this.btnViewAssets.TabIndex = 1;
            this.btnViewAssets.Text = "View Assets";
            this.btnViewAssets.UseVisualStyleBackColor = true;
            this.btnViewAssets.Click += new System.EventHandler(this.btnViewAssets_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(291, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(948, 903);
            this.pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 120);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autodesk_Applicatin.Properties.Resources.autodesk_logo_black_transparent1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(510, 133);
            this.dataGridView1.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 903);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
