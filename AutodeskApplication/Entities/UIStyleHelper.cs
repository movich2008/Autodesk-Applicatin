using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutodeskApplication
{
    public static class UIStyleHelper
    {
        public static Color ButtonBackColor = Color.SteelBlue;
        public static Color ButtonHoverColor = Color.DodgerBlue;
        public static Color ButtonTextColor = Color.White;
        public static Font ButtonFont = new Font("Poppins", 10, FontStyle.Bold);
        public static Font TextBoxFont = new Font("Segoe UI", 10);
        public static Color TextBoxTextColor = Color.Black;

        // Apply modern button look with hover effects
        public static void StyleButton(Button btn)
        {
            btn.BackColor = ButtonBackColor;
            btn.ForeColor = ButtonTextColor;
            btn.Font = ButtonFont;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            if (btn.Tag?.ToString() == "authButton")
            {
                btn.Width = 300;
                btn.Height = 40;
            }

            btn.MouseEnter += (s, e) => btn.BackColor = ButtonHoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = ButtonBackColor;
        }

        // Light style for standard TextBox (not Krypton)
        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = TextBoxFont;
            txt.ForeColor = TextBoxTextColor;
            txt.TextAlign = HorizontalAlignment.Left;
            txt.BackColor = Color.White;
            txt.BorderStyle = BorderStyle.None;
        }

        // Apply styles recursively to all buttons/textboxes in a container
        public static void StyleAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button btn)
                    StyleButton(btn);

                if (control is TextBox txt)
                    StyleTextBox(txt);

                // Don't apply to KryptonTextBox — handled separately in UIHelper

                if (control.HasChildren)
                    StyleAllControls(control);
            }
        }
    }
}
