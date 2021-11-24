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
            ApplicationConfiguration.Initialize();

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            Application.Run(new CreateTournamentForm());

            //Application.Run(new TournamentDashboardForm());
        }
    }
}