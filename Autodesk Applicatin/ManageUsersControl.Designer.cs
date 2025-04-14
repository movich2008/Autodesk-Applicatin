namespace Autodesk_Applicatin
{
    partial class ManageUsersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlUserFormContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcmbFilter = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.cmbUserFilter = new System.Windows.Forms.ComboBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.contextMenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Deactivate = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUserFormContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserFormContainer
            // 
            this.pnlUserFormContainer.Controls.Add(this.tableLayoutPanel1);
            this.pnlUserFormContainer.Controls.Add(this.lblHeader);
            this.pnlUserFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlUserFormContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUserFormContainer.Name = "pnlUserFormContainer";
            this.pnlUserFormContainer.Size = new System.Drawing.Size(1425, 906);
            this.pnlUserFormContainer.TabIndex = 0;
            this.pnlUserFormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserFormContainer_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Controls.Add(this.dgvUsers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcmbFilter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEditUser, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbUserFilter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateUser, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearch, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(148, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.86782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.284028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.82848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.284028F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 726);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Email,
            this.Role,
            this.Status,
            this.CreatedAt});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvUsers, 5);
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(4, 243);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.Size = new System.Drawing.Size(1135, 409);
            this.dgvUsers.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Items.AddRange(new object[] {
            "Active",
            "Deactivated"});
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Created at";
            this.CreatedAt.MinimumWidth = 8;
            this.CreatedAt.Name = "CreatedAt";
            // 
            // lblcmbFilter
            // 
            this.lblcmbFilter.AutoSize = true;
            this.lblcmbFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblcmbFilter.Location = new System.Drawing.Point(8, 124);
            this.lblcmbFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcmbFilter.Name = "lblcmbFilter";
            this.lblcmbFilter.Size = new System.Drawing.Size(105, 114);
            this.lblcmbFilter.TabIndex = 4;
            this.lblcmbFilter.Text = "Filter by Role:";
            this.lblcmbFilter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSize = true;
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditUser.Location = new System.Drawing.Point(763, 662);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(228, 59);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Edit Selected User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // cmbUserFilter
            // 
            this.cmbUserFilter.FormattingEnabled = true;
            this.cmbUserFilter.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Editor",
            "Manager",
            "Viewer"});
            this.cmbUserFilter.Location = new System.Drawing.Point(121, 129);
            this.cmbUserFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUserFilter.Name = "cmbUserFilter";
            this.cmbUserFilter.Size = new System.Drawing.Size(214, 28);
            this.cmbUserFilter.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreateUser.Location = new System.Drawing.Point(142, 662);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(196, 59);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Location = new System.Drawing.Point(1013, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(763, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(346, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(409, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(597, 14);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(165, 26);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Manage Users";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // contextMenuUsers
            // 
            this.contextMenuUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deactivate,
            this.Delete});
            this.contextMenuUsers.Name = "contextMenuUsers";
            this.contextMenuUsers.Size = new System.Drawing.Size(244, 68);
            // 
            // Deactivate
            // 
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.Size = new System.Drawing.Size(243, 32);
            this.Deactivate.Text = "toolStripMenuItem1";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(243, 32);
            this.Delete.Text = "Delete";
            // 
            // ManageUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserFormContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUsersControl";
            this.Size = new System.Drawing.Size(1425, 906);
            this.Load += new System.EventHandler(this.ManageUsersControl_Load);
            this.pnlUserFormContainer.ResumeLayout(false);
            this.pnlUserFormContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserFormContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem Deactivate;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblcmbFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.ComboBox cmbUserFilter;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}
