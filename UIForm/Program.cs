using System;
using System.Windows.Forms;

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
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            //Application.Run(new TournamentDashboard());
            Application.Run(new PrizeCreator());
        }
    }
}
