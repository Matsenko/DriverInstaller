using System.Security.Principal;

namespace DriverInstallerWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            ApplicationConfiguration.Initialize();
            if (!isAdmin)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Please run this application as an administrator.");
            }
        }
    }
}