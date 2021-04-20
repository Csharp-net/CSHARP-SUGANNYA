using System;
using System.IO;

namespace ExceptionHelper
{
    public class MyApplicationException : Exception
    {
        public const string filePath = @"D:\basics\Log.txt";
        public MyApplicationException(string msg)
        {
            Console.WriteLine("user defined Exception");    
        }
          public static void writeLog(string message)
          {​​ ​​​
            
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
