using System;
using System.Windows.Forms;

namespace DeadlockDetection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();         // Enables visual styles for modern UI
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());             // Starts Form1 as the main window
        }
    }
}
