namespace Autodesk_Applicatin
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
            this.SuspendLayout();
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