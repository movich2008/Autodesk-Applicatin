using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutodeskApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Optional cleanup or logging when app exits
            Application.ApplicationExit += (sender, e) =>
            {
                
                Console.WriteLine("Application is closing...");
                
            };

            // Run your login form or main app entry
            Application.Run(new LoginForm());  
        }
    }
}