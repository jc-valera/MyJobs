using TestSolWFA.BLL;
using TestSolWFA.UI;

namespace TestSolWFA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var frmMain = new Main();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(frmMain);
        }
    }
}