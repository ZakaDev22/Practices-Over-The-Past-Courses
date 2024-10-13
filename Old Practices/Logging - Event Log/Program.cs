using System;
using System.Diagnostics;


namespace Logging___Event_Log
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string SourceName = "KokoApp";

            //if (!EventLog.Exists(SourceName))
            //{
            //    EventLog.CreateEventSource(SourceName, "Application");

            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.WriteLine($"Event Source Created Successfully.");
            //}

            // Specify the source name for the event log
            string sourceName = "MyApp";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            EventLog.WriteEntry(sourceName, "This is An Information", EventLogEntryType.Information);

            EventLog.WriteEntry(sourceName, "This is An Warning", EventLogEntryType.Warning);

            EventLog.WriteEntry(sourceName, "This is An Error", EventLogEntryType.Error);

            Console.WriteLine($"Event written To LogViewer Successfully.");

            Console.ReadKey();
        }
    }
}
