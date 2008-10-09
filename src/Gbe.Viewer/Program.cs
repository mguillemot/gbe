using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Antlr.Runtime;
using Gbe.Script;

namespace Gbe.Viewer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // For number formatting...
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            // Run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Viewer());
        }
    }
}