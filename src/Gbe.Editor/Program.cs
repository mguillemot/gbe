using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Gbe.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // For number formatting...
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            // Run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Editor());
        }
    }
}
