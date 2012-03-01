using System;
using System.Windows.Forms;
using WordFiller.Framework;

namespace WordFiller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var FrmMain = new FrmMain();
            ManageWindows.Forms.Add(FrmMain);
            Application.Run(FrmMain); 
        }
    }
}
