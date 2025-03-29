namespace Autodesk_Applicatin
{
    partial class ManagerDashboard
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
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopNav.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTopNav.Controls.Add(this.lblWelcome);
            this.pnlTopNav.Location = new System.Drawing.Point(12, -104);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(318, 50);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(980, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(120, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(103, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Manager!";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainContent.Controls.Add(this.btnLogout);
            this.pnlMainContent.Controls.Add(this.pnlTopNav);
            this.pnlMainContent.Controls.Add(this.btnApplyFilter);
            this.pnlMainContent.Controls.Add(this.lblFilter);
            this.pnlMainContent.Controls.Add(this.cmbStatusFilter);
            this.pnlMainContent.Controls.Add(this.txtSearch);
            this.pnlMainContent.Controls.Add(this.lblSearch);
            this.pnlMainContent.Controls.Add(this.lblHeading);
            this.pnlMainContent.Controls.Add(this.dgvAssets);
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1099, 515);
            this.pnlMainContent.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(318, 142);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(82, 30);
            this.btnApplyFilter.TabIndex = 6;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 151);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(79, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter by Status:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(98, 148);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(204, 21);
            this.cmbStatusFilter.TabIndex = 4;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(734, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(672, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(411, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(135, 18);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Uploaded Assets";
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDescription,
            this.colDateAdded,
            this.colStatus,
            this.colUpdatedBy,
            this.colUpdatedAt});
            this.dgvAssets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAssets.Location = new System.Drawing.Point(11, 225);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(1076, 252);
            this.dgvAssets.TabIndex = 0;
            this.dgvAssets.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellValueChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "AssetName";
            this.colName.HeaderText = "Asset name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName = "AssetDescription";
            this.colDescription.HeaderText = "Asset Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDateAdded
            // 
            this.colDateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDateAdded.DataPropertyName = "DateAdded";
            this.colDateAdded.HeaderText = "Date added";
            this.colDateAdded.Name = "colDateAdded";
            this.colDateAdded.ReadOnly = true;
            this.colDateAdded.Width = 172;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatus.Width = 173;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdatedBy.DataPropertyName = "status_updated_by";
            this.colUpdatedBy.HeaderText = "Updated By";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.ReadOnly = true;
            // 
            // colUpdatedAt
            // 
            this.colUpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdatedAt.DataPropertyName = "status_updated_at";
            this.colUpdatedAt.HeaderText = "Updated At";
            this.colUpdatedAt.Name = "colUpdatedAt";
            this.colUpdatedAt.ReadOnly = true;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 515);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAdded;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedAt;
    }
}