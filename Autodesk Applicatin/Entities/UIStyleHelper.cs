using System;
using System.Drawing;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public static class UIStyleHelper
    {
        // Step 1️⃣: Define button style variables (colors, font, padding, etc.)
        public static Color ButtonBackColor = Color.SteelBlue;
        public static Color ButtonHoverColor = Color.DodgerBlue;
        public static Color ButtonTextColor = Color.White;
        public static Font ButtonFont = new Font("Poppins", 10, FontStyle.Bold);
        //public static Padding ButtonPadding = new Padding(15);
        //public static Size ButtonSize = new Size(300, 42); // Width x Height

        // TextBox style variables
        public static Font TextBoxFont = new Font("Segoe UI", 10);
        public static Color TextBoxTextColor = Color.Black;
       

        // Step 2️⃣: Apply styling to a single button
        public static void StyleButton(Button btn)
        {
            btn.BackColor = ButtonBackColor;
            btn.ForeColor = ButtonTextColor;
            btn.Font = ButtonFont;
            //btn.Padding = ButtonPadding;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            // 👉 Only apply width/height if Tag is "authButton"
            if (btn.Tag?.ToString() == "authButton")
            {
                btn.Width = 300;
                btn.Height = 40;
            }
            // Step 3️⃣: Mouse hover effects
            btn.MouseEnter += (s, e) => btn.BackColor = ButtonHoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = ButtonBackColor;
        }

        // Apply TextBox style
        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = TextBoxFont;
            txt.ForeColor = TextBoxTextColor;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.TextAlign = HorizontalAlignment.Left;
            txt.Multiline = false; // Set to true if you want multiline textbox
            txt.BackColor = Color.White;
        }


        // Step 4️⃣: Apply styling to all buttons in a container (form, panel, etc.)
        public static void StyleAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button btn)
                    StyleButton(btn);

                if (control is TextBox txt)
                    StyleTextBox(txt);

                // Recursively style buttons in child containers
                if (control.HasChildren)
                    StyleAllControls(control);
            }
        }

       
    }
}
