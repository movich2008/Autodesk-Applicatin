namespace AutodeskApplication
{
    partial class RejectionNoteForm
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblRejectionNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnRejectionNote = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(235, 117);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.MaxLength = 1000;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(612, 298);
            this.txtNote.TabIndex = 0;
            // 
            // lblRejectionNote
            // 
            this.lblRejectionNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRejectionNote.Location = new System.Drawing.Point(460, 35);
            this.lblRejectionNote.Name = "lblRejectionNote";
            this.lblRejectionNote.Size = new System.Drawing.Size(176, 35);
            this.lblRejectionNote.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblRejectionNote.StateCommon.ShortText.Color2 = System.Drawing.Color.Navy;
            this.lblRejectionNote.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectionNote.TabIndex = 53;
            this.lblRejectionNote.Values.Text = "Rejection Note";
            // 
            // btnRejectionNote
            // 
            this.btnRejectionNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRejectionNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejectionNote.Location = new System.Drawing.Point(410, 478);
            this.btnRejectionNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRejectionNote.Name = "btnRejectionNote";
            this.btnRejectionNote.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnRejectionNote.Size = new System.Drawing.Size(261, 72);
            this.btnRejectionNote.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnRejectionNote.StateCommon.Back.Color2 = System.Drawing.Color.SkyBlue;
            this.btnRejectionNote.StateCommon.Back.ColorAngle = 45F;
            this.btnRejectionNote.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRejectionNote.StateCommon.Border.Rounding = 20;
            this.btnRejectionNote.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectionNote.StateTracking.Back.ColorAngle = 45F;
            this.btnRejectionNote.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnRejectionNote.StateTracking.Border.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnRejectionNote.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRejectionNote.StateTracking.Border.Rounding = 20;
            this.btnRejectionNote.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRejectionNote.TabIndex = 54;
            this.btnRejectionNote.Values.Text = "Send your rejection note";
            // 
            // RejectionNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 656);
            this.Controls.Add(this.btnRejectionNote);
            this.Controls.Add(this.lblRejectionNote);
            this.Controls.Add(this.txtNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RejectionNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RejectionNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRejectionNote;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRejectionNote;
    }
}