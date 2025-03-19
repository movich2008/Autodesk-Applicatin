using System.Drawing;
using System.Windows.Forms;

namespace Autodesk_Applicatin
{
    public static class UIHelper
    {
        public static void CenterTextVertically(TextBox textBox)
        {
            textBox.Multiline = true;
            textBox.AutoSize = false;
            textBox.Height = 30;  
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Padding = new Padding(5); 
        }

    }
}