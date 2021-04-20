using System;
using System.IO;

namespace MyAppLogin
{
    public class MyLoginInfo
    {
        
        public const string filePath = @"D:\basics\ApartmentDemo\MyAppLogin\bin\Log.txt";

        public static void WriteLogFile(string message)
        {
            //StreamWriter sw = new StreamWriter(Stream);
            if (!File.Exists(filePath))
            {

                //sw = File.CreateText(filePath);
                //sw.WriteLine(message + DateTime.UtcNow);

                using (StreamWriter sw = new StreamWriter(filePath))
                {​​​​​
                     File.CreateText(filePath);
                    sw.WriteLine(message + DateTime.UtcNow);
                }​​​​​

            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {​​​​​
                     
                    sw.WriteLine(message + DateTime.UtcNow);
                }​​​​​
            }
           
        }




    }
}