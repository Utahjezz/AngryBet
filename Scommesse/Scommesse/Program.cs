using System;
using System.Windows.Forms;
using Scommesse.View;

namespace Scommesse
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Scommesse.Persistence.DataSaver.SaveFile("file1.sav", new Palinsesto());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AngryBet());
        }
    }
}