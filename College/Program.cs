using College.DAL;
using College.Model;

namespace College
{
    internal class Program
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
            //new SeedService().EnsureDataBaseSetup();
            new FormHandler().Run();
            Application.Run();
        }
    }
}