using System;
using System.IO;

namespace LoggingHelper
{
    public class LogInfo
    {
        public const string filePath = @"D:\basics\Log.txt";


        public static void writeLog(string message)
        {​​​​​
            
            if (!File.Exists(filePath))
            {​​​​​
                // Create a file to write to
                using (StreamWriter sw = File.CreateText(filePath))
                {​​​​​
                    sw.WriteLine(message + DateTime.UtcNow);
                }​​​​​
            }
            else
            {​​​​​
               using (StreamWriter sw = File.AppendText(filePath))
                {​​​​​
                   sw.WriteLine(message + DateTime.UtcNow);
                }​​​​​
            }​ ​​​​

       
        }
    }
}