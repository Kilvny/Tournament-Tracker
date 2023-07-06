using TrackerLibrary;

namespace TrackerUI
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

            // Setup the database connections, let's say SQL for now
            GlobalConfig.InitConnection(DatabaseType.SQL);

            //Application.Run(new CreatePrizeScreen());
            Application.Run(new CreateTeamScreen());
            //Application.Run(new MainAppScreen()); // indicates which Form should run when the app starts
        }
    }
}