namespace Autodesk_Applicatin
{
    partial class UserManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxClearForm = new System.Windows.Forms.Button();
            this.txtbxDeleteUser = new System.Windows.Forms.Button();
            this.txtbxEditUser = new System.Windows.Forms.Button();
            this.txtbxAddUser = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbxUserID = new System.Windows.Forms.TextBox();
            this.txtbxStatus = new System.Windows.Forms.Label();
            this.txtbxRole = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Management";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "ID: 11 - Name: Olivia - Email: olivia@example.com - Role: Contributor",
            "",
            "ID: 12 - Name: Ethan - Email: ethan@example.com - Role: Moderator",
            "",
            "ID: 13 - Name: Sophia - Email: sophia@example.com - Role: Subscriber",
            "",
            "ID: 14 - Name: Liam - Email: liam@example.com - Role: Viewer",
            "",
            "ID: 15 - Name: Ava - Email: ava@example.com - Role: Admin"});
            this.listBox1.Location = new System.Drawing.Point(-1, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(538, 204);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxClearForm);
            this.groupBox1.Controls.Add(this.txtbxDeleteUser);
            this.groupBox1.Controls.Add(this.txtbxEditUser);
            this.groupBox1.Controls.Add(this.txtbxAddUser);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtbxUserID);
            this.groupBox1.Controls.Add(this.txtbxStatus);
            this.groupBox1.Controls.Add(this.txtbxRole);
            this.groupBox1.Controls.Add(this.txtbxEmail);
            this.groupBox1.Controls.Add(this.txtbxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(564, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 534);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete User";
            // 
            // txtbxClearForm
            // 
            this.txtbxClearForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbxClearForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbxClearForm.Location = new System.Drawing.Point(150, 488);
            this.txtbxClearForm.Name = "txtbxClearForm";
            this.txtbxClearForm.Size = new System.Drawing.Size(122, 39);
            this.txtbxClearForm.TabIndex = 12;
            this.txtbxClearForm.Text = "Clear Form";
            this.txtbxClearForm.UseVisualStyleBackColor = false;
            // 
            // txtbxDeleteUser
            // 
            this.txtbxDeleteUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbxDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbxDeleteUser.Location = new System.Drawing.Point(301, 304);
            this.txtbxDeleteUser.Name = "txtbxDeleteUser";
            this.txtbxDeleteUser.Size = new System.Drawing.Size(122, 39);
            this.txtbxDeleteUser.TabIndex = 11;
            this.txtbxDeleteUser.Text = "Delete User";
            this.txtbxDeleteUser.UseVisualStyleBackColor = false;
            // 
            // txtbxEditUser
            // 
            this.txtbxEditUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbxEditUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbxEditUser.Location = new System.Drawing.Point(150, 410);
            this.txtbxEditUser.Name = "txtbxEditUser";
            this.txtbxEditUser.Size = new System.Drawing.Size(122, 39);
            this.txtbxEditUser.TabIndex = 10;
            this.txtbxEditUser.Text = "Edit User";
            this.txtbxEditUser.UseVisualStyleBackColor = false;
            // 
            // txtbxAddUser
            // 
            this.txtbxAddUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbxAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbxAddUser.Location = new System.Drawing.Point(0, 304);
            this.txtbxAddUser.Name = "txtbxAddUser";
            this.txtbxAddUser.Size = new System.Drawing.Size(122, 39);
            this.txtbxAddUser.TabIndex = 7;
            this.txtbxAddUser.Text = "Add User";
            this.txtbxAddUser.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 26);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 26);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 26);
            this.textBox2.TabIndex = 6;
            // 
            // txtbxUserID
            // 
            this.txtbxUserID.Location = new System.Drawing.Point(115, 40);
            this.txtbxUserID.Name = "txtbxUserID";
            this.txtbxUserID.Size = new System.Drawing.Size(186, 26);
            this.txtbxUserID.TabIndex = 5;
            // 
            // txtbxStatus
            // 
            this.txtbxStatus.AutoSize = true;
            this.txtbxStatus.Location = new System.Drawing.Point(-4, 224);
            this.txtbxStatus.Name = "txtbxStatus";
            this.txtbxStatus.Size = new System.Drawing.Size(60, 20);
            this.txtbxStatus.TabIndex = 4;
            this.txtbxStatus.Text = "Status:";
            // 
            // txtbxRole
            // 
            this.txtbxRole.AutoSize = true;
            this.txtbxRole.Location = new System.Drawing.Point(-4, 175);
            this.txtbxRole.Name = "txtbxRole";
            this.txtbxRole.Size = new System.Drawing.Size(46, 20);
            this.txtbxRole.TabIndex = 3;
            this.txtbxRole.Text = "Role:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.AutoSize = true;
            this.txtbxEmail.Location = new System.Drawing.Point(-4, 127);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(52, 20);
            this.txtbxEmail.TabIndex = 2;
            this.txtbxEmail.Text = "Email:";
            // 
            // txtbxName
            // 
            this.txtbxName.AutoSize = true;
            this.txtbxName.Location = new System.Drawing.Point(-4, 83);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(55, 20);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.Text = "Name:";
            this.txtbxName.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "AutoDesk";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(240, 8);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(211, 26);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(468, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "⌕";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(783, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "🛒";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(983, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 37);
            this.label12.TabIndex = 11;
            this.label12.Text = "🇬🇧";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(861, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 29);
            this.label14.TabIndex = 13;
            this.label14.Text = "Sign in";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 47);
            this.panel1.TabIndex = 14;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1038, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbxUserID;
        private System.Windows.Forms.Label txtbxStatus;
        private System.Windows.Forms.Label txtbxRole;
        private System.Windows.Forms.Label txtbxEmail;
        private System.Windows.Forms.Label txtbxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtbxDeleteUser;
        private System.Windows.Forms.Button txtbxEditUser;
        private System.Windows.Forms.Button txtbxAddUser;
        private System.Windows.Forms.Button txtbxClearForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
    }
}