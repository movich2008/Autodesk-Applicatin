using System.Drawing;
using System.Windows.Forms;

namespace AutodeskApplication
{
    partial class AdminWelcomeControl
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pnlAdminStats = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChartAssets = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barChart = new LiveCharts.WinForms.CartesianChart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lineChart = new LiveCharts.WinForms.CartesianChart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.barChartApprovalTime = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tblEditorStats = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.barChartTopAssets = new LiveCharts.WinForms.CartesianChart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pieChartUserStatus = new LiveCharts.WinForms.PieChart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.barChartUploadedByEditor = new LiveCharts.WinForms.CartesianChart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.barChartAssetsPerEditor = new LiveCharts.WinForms.CartesianChart();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost6 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost7 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost8 = new System.Windows.Forms.Integration.ElementHost();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminStats)).BeginInit();
            this.pnlAdminStats.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tblEditorStats.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // pnlAdminStats
            // 
            this.pnlAdminStats.Controls.Add(this.tableLayoutPanel4);
            this.pnlAdminStats.Controls.Add(this.tableStats);
            this.pnlAdminStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminStats.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminStats.Name = "pnlAdminStats";
            this.pnlAdminStats.Size = new System.Drawing.Size(1186, 779);
            this.pnlAdminStats.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlAdminStats.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlAdminStats.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 162);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1186, 617);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1180, 302);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 282);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pieChartAssets);
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 262);
            this.panel1.TabIndex = 0;
            // 
            // pieChartAssets
            // 
            this.pieChartAssets.BackColor = System.Drawing.Color.White;
            this.pieChartAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartAssets.ForeColor = System.Drawing.Color.Black;
            this.pieChartAssets.Location = new System.Drawing.Point(0, 0);
            this.pieChartAssets.Margin = new System.Windows.Forms.Padding(10);
            this.pieChartAssets.Name = "pieChartAssets";
            this.pieChartAssets.Size = new System.Drawing.Size(270, 262);
            this.pieChartAssets.TabIndex = 19;
            this.pieChartAssets.Text = "pieChart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.barChart);
            this.panel2.Controls.Add(this.elementHost2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 262);
            this.panel2.TabIndex = 0;
            // 
            // barChart
            // 
            this.barChart.BackColor = System.Drawing.Color.White;
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChart.Location = new System.Drawing.Point(0, 0);
            this.barChart.Margin = new System.Windows.Forms.Padding(10);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(270, 262);
            this.barChart.TabIndex = 20;
            this.barChart.Text = "cartesianChart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lineChart);
            this.panel3.Controls.Add(this.elementHost3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(590, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 262);
            this.panel3.TabIndex = 0;
            // 
            // lineChart
            // 
            this.lineChart.BackColor = System.Drawing.Color.White;
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Margin = new System.Windows.Forms.Padding(10);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(270, 262);
            this.lineChart.TabIndex = 21;
            this.lineChart.Text = "cartesianChart1";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.barChartApprovalTime);
            this.panel9.Controls.Add(this.elementHost4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(880, 10);
            this.panel9.Margin = new System.Windows.Forms.Padding(10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 262);
            this.panel9.TabIndex = 1;
            // 
            // barChartApprovalTime
            // 
            this.barChartApprovalTime.BackColor = System.Drawing.Color.White;
            this.barChartApprovalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartApprovalTime.Location = new System.Drawing.Point(0, 0);
            this.barChartApprovalTime.Margin = new System.Windows.Forms.Padding(10);
            this.barChartApprovalTime.Name = "barChartApprovalTime";
            this.barChartApprovalTime.Size = new System.Drawing.Size(270, 262);
            this.barChartApprovalTime.TabIndex = 0;
            this.barChartApprovalTime.Text = "cartesianChart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tblEditorStats, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1180, 303);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // tblEditorStats
            // 
            this.tblEditorStats.BackColor = System.Drawing.Color.IndianRed;
            this.tblEditorStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblEditorStats.ColumnCount = 4;
            this.tblEditorStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.97104F));
            this.tblEditorStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99735F));
            this.tblEditorStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99735F));
            this.tblEditorStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.03426F));
            this.tblEditorStats.Controls.Add(this.panel4, 0, 0);
            this.tblEditorStats.Controls.Add(this.panel5, 3, 0);
            this.tblEditorStats.Controls.Add(this.panel6, 1, 0);
            this.tblEditorStats.Controls.Add(this.panel7, 2, 0);
            this.tblEditorStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEditorStats.Location = new System.Drawing.Point(10, 10);
            this.tblEditorStats.Margin = new System.Windows.Forms.Padding(10);
            this.tblEditorStats.Name = "tblEditorStats";
            this.tblEditorStats.RowCount = 1;
            this.tblEditorStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditorStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tblEditorStats.Size = new System.Drawing.Size(1160, 283);
            this.tblEditorStats.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.barChartTopAssets);
            this.panel4.Controls.Add(this.elementHost5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(11, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 261);
            this.panel4.TabIndex = 5;
            // 
            // barChartTopAssets
            // 
            this.barChartTopAssets.BackColor = System.Drawing.Color.White;
            this.barChartTopAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartTopAssets.Location = new System.Drawing.Point(0, 0);
            this.barChartTopAssets.Margin = new System.Windows.Forms.Padding(10);
            this.barChartTopAssets.Name = "barChartTopAssets";
            this.barChartTopAssets.Size = new System.Drawing.Size(268, 261);
            this.barChartTopAssets.TabIndex = 21;
            this.barChartTopAssets.Text = "cartesianChart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pieChartUserStatus);
            this.panel5.Controls.Add(this.elementHost8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(878, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 261);
            this.panel5.TabIndex = 5;
            // 
            // pieChartUserStatus
            // 
            this.pieChartUserStatus.BackColor = System.Drawing.Color.White;
            this.pieChartUserStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartUserStatus.Location = new System.Drawing.Point(0, 0);
            this.pieChartUserStatus.Name = "pieChartUserStatus";
            this.pieChartUserStatus.Size = new System.Drawing.Size(271, 261);
            this.pieChartUserStatus.TabIndex = 0;
            this.pieChartUserStatus.Text = "pieChart1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.barChartUploadedByEditor);
            this.panel6.Controls.Add(this.elementHost6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(300, 11);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 261);
            this.panel6.TabIndex = 24;
            // 
            // barChartUploadedByEditor
            // 
            this.barChartUploadedByEditor.BackColor = System.Drawing.Color.White;
            this.barChartUploadedByEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartUploadedByEditor.Location = new System.Drawing.Point(0, 0);
            this.barChartUploadedByEditor.Name = "barChartUploadedByEditor";
            this.barChartUploadedByEditor.Size = new System.Drawing.Size(268, 261);
            this.barChartUploadedByEditor.TabIndex = 25;
            this.barChartUploadedByEditor.Text = "cartesianChart2";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.barChartAssetsPerEditor);
            this.panel7.Controls.Add(this.elementHost7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(589, 11);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 261);
            this.panel7.TabIndex = 25;
            // 
            // barChartAssetsPerEditor
            // 
            this.barChartAssetsPerEditor.BackColor = System.Drawing.Color.White;
            this.barChartAssetsPerEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChartAssetsPerEditor.Location = new System.Drawing.Point(0, 0);
            this.barChartAssetsPerEditor.Name = "barChartAssetsPerEditor";
            this.barChartAssetsPerEditor.Size = new System.Drawing.Size(268, 261);
            this.barChartAssetsPerEditor.TabIndex = 1;
            this.barChartAssetsPerEditor.Text = "cartesianChart2";
            // 
            // tableStats
            // 
            this.tableStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableStats.ColumnCount = 4;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91179F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05293F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.01764F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.01764F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStats.Controls.Add(this.grpApproved, 1, 0);
            this.tableStats.Controls.Add(this.grpPending, 2, 0);
            this.tableStats.Controls.Add(this.grpRejected, 3, 0);
            this.tableStats.Controls.Add(this.grpTotalAssets, 0, 0);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableStats.Location = new System.Drawing.Point(0, 0);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 1;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStats.Size = new System.Drawing.Size(1186, 162);
            this.tableStats.TabIndex = 18;
            // 
            // grpApproved
            // 
            this.grpApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpApproved.Location = new System.Drawing.Point(301, 6);
            this.grpApproved.Margin = new System.Windows.Forms.Padding(5);
            this.grpApproved.MinimumSize = new System.Drawing.Size(150, 100);
            this.grpApproved.Name = "grpApproved";
            // 
            // grpApproved.Panel
            // 
            this.grpApproved.Panel.Controls.Add(this.kryptonLabel6);
            this.grpApproved.Panel.Controls.Add(this.kryptonLabel2);
            this.grpApproved.Panel.Controls.Add(this.lblApprovedCount);
            this.grpApproved.Size = new System.Drawing.Size(285, 150);
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
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(281, 26);
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "Approved";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(-2, 3);
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
            this.lblApprovedCount.Size = new System.Drawing.Size(281, 144);
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
            this.grpPending.Location = new System.Drawing.Point(597, 6);
            this.grpPending.Margin = new System.Windows.Forms.Padding(5);
            this.grpPending.MinimumSize = new System.Drawing.Size(150, 100);
            this.grpPending.Name = "grpPending";
            // 
            // grpPending.Panel
            // 
            this.grpPending.Panel.Controls.Add(this.kryptonLabel7);
            this.grpPending.Panel.Controls.Add(this.kryptonLabel3);
            this.grpPending.Panel.Controls.Add(this.lblPendingCount);
            this.grpPending.Size = new System.Drawing.Size(285, 150);
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
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(281, 26);
            this.kryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 2;
            this.kryptonLabel7.Values.Text = "Pending";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(142, 3);
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
            this.lblPendingCount.Size = new System.Drawing.Size(281, 144);
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
            this.grpRejected.Location = new System.Drawing.Point(893, 6);
            this.grpRejected.Margin = new System.Windows.Forms.Padding(5);
            this.grpRejected.MinimumSize = new System.Drawing.Size(150, 100);
            this.grpRejected.Name = "grpRejected";
            // 
            // grpRejected.Panel
            // 
            this.grpRejected.Panel.Controls.Add(this.kryptonLabel8);
            this.grpRejected.Panel.Controls.Add(this.kryptonLabel4);
            this.grpRejected.Panel.Controls.Add(this.lblRejectedCount);
            this.grpRejected.Size = new System.Drawing.Size(287, 150);
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
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(283, 26);
            this.kryptonLabel8.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Rejected";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 0);
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
            this.lblRejectedCount.Size = new System.Drawing.Size(283, 144);
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
            this.grpTotalAssets.Location = new System.Drawing.Point(6, 6);
            this.grpTotalAssets.Margin = new System.Windows.Forms.Padding(5);
            this.grpTotalAssets.MinimumSize = new System.Drawing.Size(150, 100);
            this.grpTotalAssets.Name = "grpTotalAssets";
            // 
            // grpTotalAssets.Panel
            // 
            this.grpTotalAssets.Panel.Controls.Add(this.kryptonLabel5);
            this.grpTotalAssets.Panel.Controls.Add(this.kryptonLabel1);
            this.grpTotalAssets.Panel.Controls.Add(this.lblTotalAssets);
            this.grpTotalAssets.Size = new System.Drawing.Size(284, 150);
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
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(280, 26);
            this.kryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Total Assets";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 3);
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
            this.lblTotalAssets.Size = new System.Drawing.Size(280, 144);
            this.lblTotalAssets.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTotalAssets.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssets.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTotalAssets.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTotalAssets.TabIndex = 0;
            this.lblTotalAssets.Values.Text = "0";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(270, 262);
            this.elementHost1.TabIndex = 20;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(0, 0);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(270, 262);
            this.elementHost2.TabIndex = 21;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = null;
            // 
            // elementHost3
            // 
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3.Location = new System.Drawing.Point(0, 0);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(270, 262);
            this.elementHost3.TabIndex = 22;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = null;
            // 
            // elementHost4
            // 
            this.elementHost4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost4.Location = new System.Drawing.Point(0, 0);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(270, 262);
            this.elementHost4.TabIndex = 1;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = null;
            // 
            // elementHost5
            // 
            this.elementHost5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost5.Location = new System.Drawing.Point(0, 0);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(268, 261);
            this.elementHost5.TabIndex = 22;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = null;
            // 
            // elementHost6
            // 
            this.elementHost6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost6.Location = new System.Drawing.Point(0, 0);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(268, 261);
            this.elementHost6.TabIndex = 26;
            this.elementHost6.Text = "elementHost6";
            this.elementHost6.Child = null;
            // 
            // elementHost7
            // 
            this.elementHost7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost7.Location = new System.Drawing.Point(0, 0);
            this.elementHost7.Name = "elementHost7";
            this.elementHost7.Size = new System.Drawing.Size(268, 261);
            this.elementHost7.TabIndex = 2;
            this.elementHost7.Text = "elementHost7";
            this.elementHost7.Child = null;
            // 
            // elementHost8
            // 
            this.elementHost8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost8.Location = new System.Drawing.Point(0, 0);
            this.elementHost8.Name = "elementHost8";
            this.elementHost8.Size = new System.Drawing.Size(271, 261);
            this.elementHost8.TabIndex = 1;
            this.elementHost8.Text = "elementHost8";
            this.elementHost8.Child = null;
            // 
            // AdminWelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlAdminStats);
            this.Name = "AdminWelcomeControl";
            this.Size = new System.Drawing.Size(1186, 779);
            this.Load += new System.EventHandler(this.AdminWelcomeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminStats)).EndInit();
            this.pnlAdminStats.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tblEditorStats.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpApproved.Panel)).EndInit();
            this.grpApproved.Panel.ResumeLayout(false);
            this.grpApproved.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpApproved)).EndInit();
            this.grpApproved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpPending.Panel)).EndInit();
            this.grpPending.Panel.ResumeLayout(false);
            this.grpPending.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPending)).EndInit();
            this.grpPending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpRejected.Panel)).EndInit();
            this.grpRejected.Panel.ResumeLayout(false);
            this.grpRejected.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRejected)).EndInit();
            this.grpRejected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalAssets.Panel)).EndInit();
            this.grpTotalAssets.Panel.ResumeLayout(false);
            this.grpTotalAssets.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalAssets)).EndInit();
            this.grpTotalAssets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlAdminStats;
        private TableLayoutPanel tableStats;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpApproved;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblApprovedCount;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpPending;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPendingCount;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpRejected;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRejectedCount;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpTotalAssets;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalAssets;
        private ToolTip toolTip1;
        private TableLayoutPanel tblEditorStats;
        private Panel panel4;
        private LiveCharts.WinForms.CartesianChart barChartTopAssets;
        private Panel panel5;
        private LiveCharts.WinForms.PieChart pieChartUserStatus;
        private Panel panel6;
        private LiveCharts.WinForms.CartesianChart barChartUploadedByEditor;
        private Panel panel7;
        private LiveCharts.WinForms.CartesianChart barChartAssetsPerEditor;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private LiveCharts.WinForms.PieChart pieChartAssets;
        private Panel panel2;
        private LiveCharts.WinForms.CartesianChart barChart;
        private Panel panel3;
        private LiveCharts.WinForms.CartesianChart lineChart;
        private Panel panel9;
        private LiveCharts.WinForms.CartesianChart barChartApprovalTime;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private System.Windows.Forms.Integration.ElementHost elementHost8;
        private System.Windows.Forms.Integration.ElementHost elementHost6;
        private System.Windows.Forms.Integration.ElementHost elementHost7;
    }
}
