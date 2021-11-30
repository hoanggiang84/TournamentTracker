using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles) 
        {
            if (database)
            {
                // TODO: create SQL connection
                SqlConnection sqlConnection = new SqlConnection();
                Connections.Add(sqlConnection);
            }

            if (textFiles)
            {
                // TODO: create text file connection
                TextConnection textConnection = new TextConnection();
                Connections.Add(textConnection);
            }
        }
    }
}
