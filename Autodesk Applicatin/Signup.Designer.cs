namespace Autodesk_Applicatin
{
    partial class Signup
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
            this.txtbxEmail = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.Label();
            this.txtbxConfirmPassword = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.AutoSize = true;
            this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxEmail.Location = new System.Drawing.Point(157, 102);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(48, 20);
            this.txtbxEmail.TabIndex = 21;
            this.txtbxEmail.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(263, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 26);
            this.label22.TabIndex = 23;
            this.label22.Text = "Sign up";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.AutoSize = true;
            this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxPassword.Location = new System.Drawing.Point(157, 177);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(78, 20);
            this.txtbxPassword.TabIndex = 24;
            this.txtbxPassword.Text = "Password";
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.AutoSize = true;
            this.txtbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(157, 250);
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.txtbxConfirmPassword.TabIndex = 30;
            this.txtbxConfirmPassword.Text = "Confirm Password";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignup.Location = new System.Drawing.Point(161, 331);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(300, 42);
            this.btnSignup.TabIndex = 32;
            this.btnSignup.Text = "Submit";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(265, 386);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Already have an account?";
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lnkLogin.ForeColor = System.Drawing.Color.White;
            this.lnkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLogin.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lnkLogin.Location = new System.Drawing.Point(425, 386);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(36, 13);
            this.lnkLogin.TabIndex = 37;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Log in";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(161, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(161, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.Location = new System.Drawing.Point(161, 273);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 20);
            this.txtConfirmPassword.TabIndex = 38;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signup
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtbxConfirmPassword);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtbxEmail);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtbxEmail;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txtbxPassword;
        private System.Windows.Forms.Label txtbxConfirmPassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}