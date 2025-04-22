namespace AutodeskApplication
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
            this.userContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pnlUserFormContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvViewerActivity = new System.Windows.Forms.DataGridView();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtSearchActivity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUserActivity = new System.Windows.Forms.DataGridView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbRoleOrActivityFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtSearchUserActivity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbUserFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblcmbFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.userContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserFormContainer)).BeginInit();
            this.pnlUserFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewerActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRoleOrActivityFilter)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userContextMenu
            // 
            this.userContextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.userContextMenu.Name = "contextMenuUsers";
            this.userContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 22);
            this.Delete.Text = "Delete";
            // 
            // pnlUserFormContainer
            // 
            this.pnlUserFormContainer.Controls.Add(this.kryptonPanel3);
            this.pnlUserFormContainer.Controls.Add(this.kryptonPanel1);
            this.pnlUserFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlUserFormContainer.Name = "pnlUserFormContainer";
            this.pnlUserFormContainer.Size = new System.Drawing.Size(1476, 642);
            this.pnlUserFormContainer.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.tableLayoutPanel3);
            this.kryptonPanel3.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 49);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1476, 593);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.kryptonPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 266);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1476, 327);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.tableLayoutPanel5);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(732, 321);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.060109F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.8306F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.2459F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.46448F));
            this.tableLayoutPanel5.Controls.Add(this.dgvViewerActivity, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.kryptonLabel10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonLabel9, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonLabel11, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbFilter, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSearchActivity, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(732, 321);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // dgvViewerActivity
            // 
            this.dgvViewerActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewerActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewerActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel5.SetColumnSpan(this.dgvViewerActivity, 5);
            this.dgvViewerActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewerActivity.Location = new System.Drawing.Point(3, 46);
            this.dgvViewerActivity.Name = "dgvViewerActivity";
            this.dgvViewerActivity.ReadOnly = true;
            this.dgvViewerActivity.Size = new System.Drawing.Size(726, 272);
            this.dgvViewerActivity.TabIndex = 10;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel10.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(139, 37);
            this.kryptonLabel10.TabIndex = 9;
            this.kryptonLabel10.Values.Text = "Recent Viewer Activities";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel9.Location = new System.Drawing.Point(153, 3);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(47, 37);
            this.kryptonLabel9.TabIndex = 8;
            this.kryptonLabel9.Values.Text = "Search";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel11.Location = new System.Drawing.Point(468, 3);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(37, 37);
            this.kryptonLabel11.TabIndex = 7;
            this.kryptonLabel11.Values.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbFilter.DropDownWidth = 121;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Week",
            "This Month"});
            this.cmbFilter.Location = new System.Drawing.Point(518, 10);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.cmbFilter.Size = new System.Drawing.Size(204, 21);
            this.cmbFilter.TabIndex = 2;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // txtSearchActivity
            // 
            this.txtSearchActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchActivity.Location = new System.Drawing.Point(213, 10);
            this.txtSearchActivity.Margin = new System.Windows.Forms.Padding(10);
            this.txtSearchActivity.Name = "txtSearchActivity";
            this.txtSearchActivity.Size = new System.Drawing.Size(211, 23);
            this.txtSearchActivity.TabIndex = 1;
            this.txtSearchActivity.TextChanged += new System.EventHandler(this.txtSearchActivity_TextChanged);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.tableLayoutPanel6);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(741, 3);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(732, 321);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53005F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3224F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.240437F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.82514F));
            this.tableLayoutPanel6.Controls.Add(this.dgvUserActivity, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel3, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmbRoleOrActivityFilter, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSearchUserActivity, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(732, 321);
            this.tableLayoutPanel6.TabIndex = 27;
            // 
            // dgvUserActivity
            // 
            this.dgvUserActivity.AllowUserToAddRows = false;
            this.dgvUserActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserActivity.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel6.SetColumnSpan(this.dgvUserActivity, 5);
            this.dgvUserActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserActivity.Location = new System.Drawing.Point(3, 44);
            this.dgvUserActivity.Name = "dgvUserActivity";
            this.dgvUserActivity.ReadOnly = true;
            this.dgvUserActivity.Size = new System.Drawing.Size(726, 274);
            this.dgvUserActivity.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(121, 35);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "User Session History";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel2.Location = new System.Drawing.Point(217, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 35);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Search";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonLabel3.Location = new System.Drawing.Point(480, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(37, 35);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Filter";
            // 
            // cmbRoleOrActivityFilter
            // 
            this.cmbRoleOrActivityFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbRoleOrActivityFilter.DropDownWidth = 121;
            this.cmbRoleOrActivityFilter.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Editor",
            "Manager",
            "Viewer",
            "Login",
            "Logout"});
            this.cmbRoleOrActivityFilter.Location = new System.Drawing.Point(530, 10);
            this.cmbRoleOrActivityFilter.Margin = new System.Windows.Forms.Padding(10);
            this.cmbRoleOrActivityFilter.Name = "cmbRoleOrActivityFilter";
            this.cmbRoleOrActivityFilter.Size = new System.Drawing.Size(192, 21);
            this.cmbRoleOrActivityFilter.TabIndex = 2;
            this.cmbRoleOrActivityFilter.SelectedIndexChanged += new System.EventHandler(this.cmbRoleOrActivityFilter_SelectedIndexChanged);
            // 
            // txtSearchUserActivity
            // 
            this.txtSearchUserActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchUserActivity.Location = new System.Drawing.Point(277, 10);
            this.txtSearchUserActivity.Margin = new System.Windows.Forms.Padding(10);
            this.txtSearchUserActivity.Name = "txtSearchUserActivity";
            this.txtSearchUserActivity.Size = new System.Drawing.Size(180, 23);
            this.txtSearchUserActivity.TabIndex = 1;
            this.txtSearchUserActivity.TextChanged += new System.EventHandler(this.txtSearchUserActivity_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 768F));
            this.tableLayoutPanel2.Controls.Add(this.kryptonPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1476, 593);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // kryptonPanel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.kryptonPanel2, 2);
            this.kryptonPanel2.Controls.Add(this.dgvUsers);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1470, 196);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user_tag,
            this.first_name,
            this.last_name,
            this.email,
            this.role,
            this.status,
            this.created_at});
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1470, 196);
            this.dgvUsers.TabIndex = 8;
            this.dgvUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_CellMouseDown);
            this.dgvUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsers_CurrentCellDirtyStateChanged_1);
            this.dgvUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUsers_DataBindingComplete);
            this.dgvUsers.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvUsers_EditingControlShowing);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // user_tag
            // 
            this.user_tag.DataPropertyName = "user_tag";
            this.user_tag.HeaderText = "User Tag";
            this.user_tag.Name = "user_tag";
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "Active",
            "Deactivated"});
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created At";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.54248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.45752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 506F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditUser, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateUser, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1470, 61);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSize = true;
            this.btnEditUser.Location = new System.Drawing.Point(781, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(131, 37);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Edit Selected User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.Location = new System.Drawing.Point(535, 3);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(159, 40);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1476, 49);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48352F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51648F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel4.Controls.Add(this.txtSearch, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbUserFilter, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblSearch, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblcmbFilter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblHeader, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1476, 49);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1177, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbUserFilter
            // 
            this.cmbUserFilter.FormattingEnabled = true;
            this.cmbUserFilter.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Editor",
            "Manager",
            "Viewer",
            "Active",
            "Deactivated"});
            this.cmbUserFilter.Location = new System.Drawing.Point(248, 5);
            this.cmbUserFilter.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.cmbUserFilter.Name = "cmbUserFilter";
            this.cmbUserFilter.Size = new System.Drawing.Size(175, 21);
            this.cmbUserFilter.TabIndex = 20;
            this.cmbUserFilter.SelectedIndexChanged += new System.EventHandler(this.cmbUserFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Location = new System.Drawing.Point(1117, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Values.Text = "Search";
            // 
            // lblcmbFilter
            // 
            this.lblcmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcmbFilter.Location = new System.Drawing.Point(151, 3);
            this.lblcmbFilter.Name = "lblcmbFilter";
            this.lblcmbFilter.Size = new System.Drawing.Size(84, 20);
            this.lblcmbFilter.TabIndex = 18;
            this.lblcmbFilter.Values.Text = "Filter By Role:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(575, 5);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(314, 18);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "Manage Users";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserFormContainer);
            this.Name = "ManageUsersControl";
            this.Size = new System.Drawing.Size(1476, 642);
            this.userContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserFormContainer)).EndInit();
            this.pnlUserFormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewerActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRoleOrActivityFilter)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlUserFormContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnCreateUser;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbUserFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblcmbFilter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvViewerActivity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchActivity;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dgvUserActivity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRoleOrActivityFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchUserActivity;
        private System.Windows.Forms.ContextMenuStrip userContextMenu;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}
