using System.Diagnostics;
using UltimateBattleSimulator.UI;

namespace UltimateBattleSimulator
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
            try
            {
                Application.Run(new UTBS());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}