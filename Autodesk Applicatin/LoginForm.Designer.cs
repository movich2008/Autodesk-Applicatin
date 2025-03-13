namespace Autodesk_Applicatin
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLableCreateAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(419, 270);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(419, 238);
            this.txtbxpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.Size = new System.Drawing.Size(235, 22);
            this.txtbxpassword.TabIndex = 1;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(419, 206);
            this.txtbxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(235, 22);
            this.txtbxUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log in";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LinkLableCreateAccount
            // 
            this.LinkLableCreateAccount.AutoSize = true;
            this.LinkLableCreateAccount.Location = new System.Drawing.Point(487, 302);
            this.LinkLableCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLableCreateAccount.Name = "LinkLableCreateAccount";
            this.LinkLableCreateAccount.Size = new System.Drawing.Size(98, 16);
            this.LinkLableCreateAccount.TabIndex = 4;
            this.LinkLableCreateAccount.TabStop = true;
            this.LinkLableCreateAccount.Text = "Create Account";
            this.LinkLableCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLableCreateAccount_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LinkLableCreateAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.txtbxpassword);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkLableCreateAccount;
    }
}

