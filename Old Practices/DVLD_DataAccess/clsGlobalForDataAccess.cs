using System.Diagnostics;

namespace DVLD_DataAccess
{


    public static class clsGlobalForDataAccess
    {
        // LogEvent Viewer Method

        private static string _SourceName = "MyDVLD";

        /// <summary>
        ///   This Method For Loging Try Catch Exception From Data Access For This Project
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="type"></param>
        public static void LogExseptionsToLogerViewr(string Message, EventLogEntryType type)
        {
            if (!EventLog.SourceExists(_SourceName))
            {
                EventLog.CreateEventSource(_SourceName, "Application");
            }


            EventLog.WriteEntry(_SourceName, Message, type);
        }
    }
}
