using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace UIForm
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

            // Initialzie the database connection
            GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            //Application.Run(new TournamentDashboard());
            Application.Run(new TournamentCreator());
        }
    }
}
