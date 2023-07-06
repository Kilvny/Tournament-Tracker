using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DB_Connection;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; } 
        public static IDataConnection PersonConnection { get; private set; }
        public static void InitConnection(DatabaseType db) 
        {
            if (db == DatabaseType.SQL)
            {
                // DONE - Setup the SQL connection properly
                SQLConnector sqlC = new SQLConnector(); // same as = new();
                Connections = (sqlC);
                PersonConnection = (sqlC);
            }

            if (db == DatabaseType.Textfile)
            {
                // TODO - Create TextFile Connection
                TextFileConnector textC = new(); // same is = new TextFileConnector();
                Connections = (textC);
                PersonConnection = (textC);
            }
        }

        /// <summary>
        /// Get connectionString's settings 
        /// </summary>
        /// <param name="name">Name of connection string</param>
        /// <returns>ConnectionString</returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
