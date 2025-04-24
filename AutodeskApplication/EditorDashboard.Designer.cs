namespace AutodeskApplication
{
    partial class EditorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorDashboard));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanelHeader = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblNotificationCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picNotificationBell = new System.Windows.Forms.PictureBox();
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.flowNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.grpApproved = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblApprovedCount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grpPending = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPendingCount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grpRejected = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRejectedCount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grpTotalAssets = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotalAssets = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAssetViewer = new System.Windows.Forms.PictureBox();
            this.pnlEditorButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditAsset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddAssetByEditor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlEditor = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).BeginInit();
            this.kryptonPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotificationBell)).BeginInit();
            this.pnlNotifications.SuspendLayout();
            this.tableStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpApproved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpApproved.Panel)).BeginInit();
            this.grpApproved.Panel.SuspendLayout();
            this.grpApproved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPending.Panel)).BeginInit();
            this.grpPending.Panel.SuspendLayout();
            this.grpPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRejected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpRejected.Panel)).BeginInit();
            this.grpRejected.Panel.SuspendLayout();
            this.grpRejected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalAssets.Panel)).BeginInit();
            this.grpTotalAssets.Panel.SuspendLayout();
            this.grpTotalAssets.SuspendLayout();
            this.tableMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAssetViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEditorButtons)).BeginInit();
            this.pnlEditorButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEditor)).BeginInit();
            this.pnlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanelHeader
            // 
            this.kryptonPanelHeader.Controls.Add(this.lblNotificationCount);
            this.kryptonPanelHeader.Controls.Add(this.picNotificationBell);
            this.kryptonPanelHeader.Controls.Add(this.lblTitle);
            this.kryptonPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanelHeader.Name = "kryptonPanelHeader";
            this.kryptonPanelHeader.Size = new System.Drawing.Size(1751, 74);
            this.kryptonPanelHeader.TabIndex = 0;
            // 
            // lblNotificationCount
            // 
            this.lblNotificationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificationCount.AutoSize = true;
            this.lblNotificationCount.BackColor = System.Drawing.Color.Red;
            this.lblNotificationCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationCount.ForeColor = System.Drawing.Color.White;
            this.lblNotificationCount.Location = new System.Drawing.Point(1646, 15);
            this.lblNotificationCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationCount.Name = "lblNotificationCount";
            this.lblNotificationCount.Size = new System.Drawing.Size(17, 19);
            this.lblNotificationCount.TabIndex = 2;
            this.lblNotificationCount.Text = "0";
            this.lblNotificationCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picNotificationBell
            // 
            this.picNotificationBell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNotificationBell.BackColor = System.Drawing.Color.Transparent;
            this.picNotificationBell.Image = ((System.Drawing.Image)(resources.GetObject("picNotificationBell.Image")));
            this.picNotificationBell.Location = new System.Drawing.Point(1619, 15);
            this.picNotificationBell.Margin = new System.Windows.Forms.Padding(4);
            this.picNotificationBell.Name = "picNotificationBell";
            this.picNotificationBell.Size = new System.Drawing.Size(56, 32);
            this.picNotificationBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNotificationBell.TabIndex = 1;
            this.picNotificationBell.TabStop = false;
            this.picNotificationBell.Click += new System.EventHandler(this.picNotificationBell_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(13, 12, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 74);
            this.lblTitle.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "Editor Dashboard";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotifications.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.flowNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(1351, 74);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(399, 307);
            this.pnlNotifications.TabIndex = 3;
            this.pnlNotifications.Visible = false;
            // 
            // flowNotifications
            // 
            this.flowNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowNotifications.AutoScroll = true;
            this.flowNotifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNotifications.Location = new System.Drawing.Point(-1, 1);
            this.flowNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.flowNotifications.Name = "flowNotifications";
            this.flowNotifications.Size = new System.Drawing.Size(397, 305);
            this.flowNotifications.TabIndex = 0;
            this.flowNotifications.WrapContents = false;
            // 
            // tableStats
            // 
            this.tableStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableStats.ColumnCount = 4;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableStats.Controls.Add(this.grpApproved, 1, 0);
            this.tableStats.Controls.Add(this.grpPending, 2, 0);
            this.tableStats.Controls.Add(this.grpRejected, 3, 0);
            this.tableStats.Controls.Add(this.grpTotalAssets, 0, 0);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableStats.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableStats.Location = new System.Drawing.Point(0, 74);
            this.tableStats.Margin = new System.Windows.Forms.Padding(4);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 1;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStats.Size = new System.Drawing.Size(1751, 197);
            this.tableStats.TabIndex = 1;
            // 
            // grpApproved
            // 
            this.grpApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpApproved.Location = new System.Drawing.Point(445, 7);
            this.grpApproved.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpApproved.MinimumSize = new System.Drawing.Size(200, 123);
            this.grpApproved.Name = "grpApproved";
            // 
            // grpApproved.Panel
            // 
            this.grpApproved.Panel.Controls.Add(this.kryptonLabel6);
            this.grpApproved.Panel.Controls.Add(this.kryptonLabel2);
            this.grpApproved.Panel.Controls.Add(this.lblApprovedCount);
            this.grpApproved.Size = new System.Drawing.Size(422, 183);
            this.grpApproved.StateCommon.Back.Color1 = System.Drawing.Color.ForestGreen;
            this.grpApproved.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApproved.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpApproved.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpApproved.TabIndex = 0;
            this.grpApproved.Values.Heading = "";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(418, 32);
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "Approved";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(-3, 4);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "";
            // 
            // lblApprovedCount
            // 
            this.lblApprovedCount.AutoSize = false;
            this.lblApprovedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApprovedCount.Location = new System.Drawing.Point(0, 0);
            this.lblApprovedCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblApprovedCount.Name = "lblApprovedCount";
            this.lblApprovedCount.Size = new System.Drawing.Size(418, 177);
            this.lblApprovedCount.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblApprovedCount.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedCount.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblApprovedCount.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblApprovedCount.TabIndex = 0;
            this.lblApprovedCount.Values.Text = "0";
            // 
            // grpPending
            // 
            this.grpPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPending.Location = new System.Drawing.Point(882, 7);
            this.grpPending.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpPending.MinimumSize = new System.Drawing.Size(200, 123);
            this.grpPending.Name = "grpPending";
            // 
            // grpPending.Panel
            // 
            this.grpPending.Panel.Controls.Add(this.kryptonLabel7);
            this.grpPending.Panel.Controls.Add(this.kryptonLabel3);
            this.grpPending.Panel.Controls.Add(this.lblPendingCount);
            this.grpPending.Size = new System.Drawing.Size(422, 183);
            this.grpPending.StateCommon.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.grpPending.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPending.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpPending.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpPending.TabIndex = 0;
            this.grpPending.Values.Heading = "";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(418, 32);
            this.kryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 2;
            this.kryptonLabel7.Values.Text = "Pending";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(189, 4);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = false;
            this.lblPendingCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingCount.Location = new System.Drawing.Point(0, 0);
            this.lblPendingCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(418, 177);
            this.lblPendingCount.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblPendingCount.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingCount.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPendingCount.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPendingCount.TabIndex = 0;
            this.lblPendingCount.Values.Text = "0";
            // 
            // grpRejected
            // 
            this.grpRejected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRejected.Location = new System.Drawing.Point(1319, 7);
            this.grpRejected.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpRejected.MinimumSize = new System.Drawing.Size(200, 123);
            this.grpRejected.Name = "grpRejected";
            // 
            // grpRejected.Panel
            // 
            this.grpRejected.Panel.Controls.Add(this.kryptonLabel8);
            this.grpRejected.Panel.Controls.Add(this.kryptonLabel4);
            this.grpRejected.Panel.Controls.Add(this.lblRejectedCount);
            this.grpRejected.Size = new System.Drawing.Size(424, 183);
            this.grpRejected.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.grpRejected.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRejected.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpRejected.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpRejected.TabIndex = 0;
            this.grpRejected.Values.Heading = "";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel8.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(420, 32);
            this.kryptonLabel8.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Rejected";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(4, 0);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel4.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "";
            // 
            // lblRejectedCount
            // 
            this.lblRejectedCount.AutoSize = false;
            this.lblRejectedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRejectedCount.Location = new System.Drawing.Point(0, 0);
            this.lblRejectedCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblRejectedCount.Name = "lblRejectedCount";
            this.lblRejectedCount.Size = new System.Drawing.Size(420, 177);
            this.lblRejectedCount.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblRejectedCount.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedCount.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRejectedCount.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRejectedCount.TabIndex = 0;
            this.lblRejectedCount.Values.Text = "0";
            // 
            // grpTotalAssets
            // 
            this.grpTotalAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTotalAssets.Location = new System.Drawing.Point(8, 7);
            this.grpTotalAssets.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpTotalAssets.MinimumSize = new System.Drawing.Size(200, 123);
            this.grpTotalAssets.Name = "grpTotalAssets";
            // 
            // grpTotalAssets.Panel
            // 
            this.grpTotalAssets.Panel.Controls.Add(this.kryptonLabel5);
            this.grpTotalAssets.Panel.Controls.Add(this.kryptonLabel1);
            this.grpTotalAssets.Panel.Controls.Add(this.lblTotalAssets);
            this.grpTotalAssets.Size = new System.Drawing.Size(422, 183);
            this.grpTotalAssets.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.grpTotalAssets.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalAssets.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpTotalAssets.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.grpTotalAssets.TabIndex = 0;
            this.grpTotalAssets.Values.Heading = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(418, 32);
            this.kryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Total Assets";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 4);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "";
            // 
            // lblTotalAssets
            // 
            this.lblTotalAssets.AutoSize = false;
            this.lblTotalAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAssets.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAssets.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalAssets.Name = "lblTotalAssets";
            this.lblTotalAssets.Size = new System.Drawing.Size(418, 177);
            this.lblTotalAssets.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTotalAssets.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssets.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTotalAssets.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTotalAssets.TabIndex = 0;
            this.lblTotalAssets.Values.Text = "0";
            // 
            // tableMainContent
            // 
            this.tableMainContent.ColumnCount = 2;
            this.tableMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableMainContent.Controls.Add(this.dgvAssets, 0, 0);
            this.tableMainContent.Controls.Add(this.picAssetViewer, 1, 0);
            this.tableMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMainContent.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableMainContent.Location = new System.Drawing.Point(0, 271);
            this.tableMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.tableMainContent.Name = "tableMainContent";
            this.tableMainContent.RowCount = 1;
            this.tableMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMainContent.Size = new System.Drawing.Size(1751, 301);
            this.tableMainContent.TabIndex = 2;
            // 
            // dgvAssets
            // 
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssets.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssets.Location = new System.Drawing.Point(4, 4);
            this.dgvAssets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(1343, 293);
            this.dgvAssets.TabIndex = 0;
            this.dgvAssets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAssets_CellFormatting);
            this.dgvAssets.SelectionChanged += new System.EventHandler(this.dgvAssets_SelectionChanged);
            // 
            // picAssetViewer
            // 
            this.picAssetViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAssetViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAssetViewer.Location = new System.Drawing.Point(1355, 4);
            this.picAssetViewer.Margin = new System.Windows.Forms.Padding(4);
            this.picAssetViewer.Name = "picAssetViewer";
            this.picAssetViewer.Size = new System.Drawing.Size(392, 293);
            this.picAssetViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAssetViewer.TabIndex = 1;
            this.picAssetViewer.TabStop = false;
          
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label3);
          
          
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 67);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(707, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 42);
            this.label3.TabIndex = 21;
            this.label3.Text = "Editor Dashboard";
            // 
            // pnlEditorButtons
            // 
            this.pnlEditorButtons.Controls.Add(this.btnLogout);
            this.pnlEditorButtons.Controls.Add(this.btnEditAsset);
            this.pnlEditorButtons.Controls.Add(this.btnAddAssetByEditor);
            this.pnlEditorButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditorButtons.Location = new System.Drawing.Point(0, 498);
            this.pnlEditorButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEditorButtons.Name = "pnlEditorButtons";
            this.pnlEditorButtons.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlEditorButtons.Size = new System.Drawing.Size(1751, 74);
            this.pnlEditorButtons.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(1556, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnLogout.Size = new System.Drawing.Size(187, 55);
            this.btnLogout.StateCommon.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btnLogout.StateCommon.Back.Color2 = System.Drawing.Color.Tomato;
            this.btnLogout.StateCommon.Back.ColorAngle = 45F;
            this.btnLogout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.StateCommon.Border.Rounding = 20;
            this.btnLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.StateTracking.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btnLogout.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.StateTracking.Back.ColorAngle = 45F;
            this.btnLogout.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLogout.StateTracking.Border.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.StateTracking.Border.Rounding = 20;
            this.btnLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Values.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditAsset
            // 
            this.btnEditAsset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAsset.Location = new System.Drawing.Point(260, 12);
            this.btnEditAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAsset.Name = "btnEditAsset";
            this.btnEditAsset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnEditAsset.Size = new System.Drawing.Size(187, 55);
            this.btnEditAsset.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnEditAsset.StateCommon.Back.Color2 = System.Drawing.Color.SkyBlue;
            this.btnEditAsset.StateCommon.Back.ColorAngle = 45F;
            this.btnEditAsset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditAsset.StateCommon.Border.Rounding = 20;
            this.btnEditAsset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAsset.StateTracking.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.btnEditAsset.StateTracking.Back.Color2 = System.Drawing.Color.PeachPuff;
            this.btnEditAsset.StateTracking.Back.ColorAngle = 45F;
            this.btnEditAsset.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditAsset.StateTracking.Border.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnEditAsset.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditAsset.StateTracking.Border.Rounding = 20;
            this.btnEditAsset.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditAsset.TabIndex = 0;
            this.btnEditAsset.Values.Text = "Edit Selected";
            this.btnEditAsset.Click += new System.EventHandler(this.btnEditAsset_Click);
            // 
            // btnAddAssetByEditor
            // 
            this.btnAddAssetByEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAssetByEditor.Location = new System.Drawing.Point(13, 12);
            this.btnAddAssetByEditor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAssetByEditor.Name = "btnAddAssetByEditor";
            this.btnAddAssetByEditor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnAddAssetByEditor.Size = new System.Drawing.Size(187, 55);
            this.btnAddAssetByEditor.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnAddAssetByEditor.StateCommon.Back.Color2 = System.Drawing.Color.SkyBlue;
            this.btnAddAssetByEditor.StateCommon.Back.ColorAngle = 45F;
            this.btnAddAssetByEditor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAssetByEditor.StateCommon.Border.Rounding = 20;
            this.btnAddAssetByEditor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssetByEditor.StateTracking.Back.ColorAngle = 45F;
            this.btnAddAssetByEditor.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnAddAssetByEditor.StateTracking.Border.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnAddAssetByEditor.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAssetByEditor.StateTracking.Border.Rounding = 20;
            this.btnAddAssetByEditor.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAssetByEditor.TabIndex = 0;
            this.btnAddAssetByEditor.Values.Text = "Add Asset";
            this.btnAddAssetByEditor.Click += new System.EventHandler(this.btnAddAssetByEditor_Click);
            // 
            // pnlEditor
            // 
            this.pnlEditor.Controls.Add(this.pnlNotifications);
            this.pnlEditor.Controls.Add(this.pnlEditorButtons);
            this.pnlEditor.Controls.Add(this.tableMainContent);
            this.pnlEditor.Controls.Add(this.tableStats);
            this.pnlEditor.Controls.Add(this.kryptonPanelHeader);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(1751, 572);
            this.pnlEditor.TabIndex = 3;
            // 
            // EditorDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1005, 675);
            this.Name = "EditorDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.Label label14;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpApproved;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpTotalAssets;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpPending;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpRejected;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedCount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPendingCount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRejectedCount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalAssets;
        private System.Windows.Forms.TableLayoutPanel tableMainContent;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAssetViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlEditorButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddAssetByEditor;
        private System.Windows.Forms.PictureBox picNotificationBell;
        private System.Windows.Forms.Label lblNotificationCount;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.FlowLayoutPanel flowNotifications;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditAsset;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogout;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}