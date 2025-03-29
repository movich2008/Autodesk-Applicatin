namespace Autodesk_Applicatin
{
    partial class UserCreationForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFullName.Location = new System.Drawing.Point(3, 45);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 45);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(86, 48);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(236, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmail.Location = new System.Drawing.Point(3, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 45);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(86, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPassword.Location = new System.Drawing.Point(3, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 45);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(86, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRole.Location = new System.Drawing.Point(3, 180);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 45);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Select Role:";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(86, 183);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(236, 21);
            this.cmbUserRole.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Location = new System.Drawing.Point(86, 273);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(236, 39);
            this.btnSaveUser.TabIndex = 7;
            this.btnSaveUser.Text = "Register";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMessage.Location = new System.Drawing.Point(204, 321);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Deactivated"});
            this.cmbStatus.Location = new System.Drawing.Point(86, 228);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(236, 21);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.84615F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.15385F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMessage, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveUser, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbUserRole, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 340);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // UserCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserCreationForm";
            this.Load += new System.EventHandler(this.UserCreationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}