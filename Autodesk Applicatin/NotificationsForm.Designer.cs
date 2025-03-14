namespace Autodesk_Applicatin
{
    partial class NotificationsForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbxFilterBy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbxSearchNotifications = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtbxUnreadNotifications = new System.Windows.Forms.Label();
            this.txtbxReadNotifications = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notficiations";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\"🔔 Your model \'BridgeDesign.dwg\' was successfully saved.\"",
            "",
            "",
            "\"🔔 John shared the \'HousePlan2023\' project with you.\"",
            "",
            "",
            "\"🔔 AutoCAD version 2025.3 is now available for update.\"",
            "",
            "",
            "\"🔔 A new update is available for AutoCAD.\"",
            "",
            "",
            "\"🔔 You successfully downloaded \'WarehousePlan2025.dwg\'.\""});
            this.listBox1.Location = new System.Drawing.Point(36, 445);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 204);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Notifications",
            "",
            "Unread Only",
            "",
            "System Alerts",
            "",
            "Collaboration Updates",
            "",
            "File Actions"});
            this.comboBox1.Location = new System.Drawing.Point(339, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "All Notifications";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbxFilterBy
            // 
            this.txtbxFilterBy.AutoSize = true;
            this.txtbxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFilterBy.Location = new System.Drawing.Point(213, 278);
            this.txtbxFilterBy.Name = "txtbxFilterBy";
            this.txtbxFilterBy.Size = new System.Drawing.Size(80, 25);
            this.txtbxFilterBy.TabIndex = 4;
            this.txtbxFilterBy.Text = "Filter by";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 5;
            // 
            // txtbxSearchNotifications
            // 
            this.txtbxSearchNotifications.AutoSize = true;
            this.txtbxSearchNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearchNotifications.Location = new System.Drawing.Point(142, 186);
            this.txtbxSearchNotifications.Name = "txtbxSearchNotifications";
            this.txtbxSearchNotifications.Size = new System.Drawing.Size(182, 25);
            this.txtbxSearchNotifications.TabIndex = 6;
            this.txtbxSearchNotifications.Text = "Search notifications";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 74);
            this.panel1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(598, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "🇬🇧";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(537, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Sign in";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "🛒";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 10);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(229, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "⌕";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(2, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "AutoDesk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(691, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "⌕";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "✔️ \"Your model \'BridgeDesign.dwg\' was   successfully saved.\"              ",
            "      (14 March 2025, 02:34 AM) ",
            "",
            "",
            "✔️ \"The project \'HousePlan2023\' was    archived successfully.\"      ",
            "           (13 March 2025, 10:15 PM)",
            "",
            "",
            "✔️ \"AutoCAD license has been renewed    successfully.\"         ",
            "                  (12 March 2025, 07:48 PM) ",
            "",
            "✔️ \"Backup completed for \'Draft1234\'.\"",
            "(11 March 2025, 03:22 PM)  "});
            this.listBox2.Location = new System.Drawing.Point(582, 445);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(468, 204);
            this.listBox2.TabIndex = 14;
            // 
            // txtbxUnreadNotifications
            // 
            this.txtbxUnreadNotifications.AutoSize = true;
            this.txtbxUnreadNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUnreadNotifications.Location = new System.Drawing.Point(155, 396);
            this.txtbxUnreadNotifications.Name = "txtbxUnreadNotifications";
            this.txtbxUnreadNotifications.Size = new System.Drawing.Size(183, 25);
            this.txtbxUnreadNotifications.TabIndex = 15;
            this.txtbxUnreadNotifications.Text = "Unread notifications";
            // 
            // txtbxReadNotifications
            // 
            this.txtbxReadNotifications.AutoSize = true;
            this.txtbxReadNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxReadNotifications.Location = new System.Drawing.Point(726, 405);
            this.txtbxReadNotifications.Name = "txtbxReadNotifications";
            this.txtbxReadNotifications.Size = new System.Drawing.Size(165, 25);
            this.txtbxReadNotifications.TabIndex = 16;
            this.txtbxReadNotifications.Text = "Read notifications";
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1093, 680);
            this.Controls.Add(this.txtbxReadNotifications);
            this.Controls.Add(this.txtbxUnreadNotifications);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbxSearchNotifications);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbxFilterBy);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NotificationsForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtbxFilterBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtbxSearchNotifications;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label txtbxUnreadNotifications;
        private System.Windows.Forms.Label txtbxReadNotifications;
    }
}