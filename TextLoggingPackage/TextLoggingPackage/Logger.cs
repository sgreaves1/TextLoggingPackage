using System;
using System.IO;

namespace TextLoggingPackage
{
    public class Logger
    {
        public static LoggingLevel ApplicationLoggingLevel = LoggingLevel.Critical;

        public static void Log(string message, string applicationName, LoggingLevel level)
        {
            if ((int)level <= (int)ApplicationLoggingLevel)
            {
                // Date Time Application name: Message
                // 18/01/2017 12:55 SmartHome: Failed to read xml file located at "C:\Users\Sam\SmartHome\Data\Data.xml"! 
                StreamWriter file = new StreamWriter("Log.txt");

                file.WriteLine(DateTime.Now + applicationName + ": " + message);

                file.Close();
            }
        }
    }
}
