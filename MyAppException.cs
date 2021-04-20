using System;
using System.IO;

namespace ExceptionHelperDemo
{
    public class MyAppException : Exception
    {
        public const string filePath = @"D:\basics\ApartmentDemo\ExceptionHelperDemo\bin\Exception.txt";
        public MyAppException(string message)
        {
            Console.WriteLine("user defined Exception");
            StreamWriter sw = new StreamWriter(filePath);
            if (!File.Exists(filePath))
            {

                sw = File.CreateText(filePath);
                sw.WriteLine(message + DateTime.UtcNow);


                //using (StreamWriter sw = File.CreateText(filePath))
                //{​​​​​
                //    sw.WriteLine(message + DateTime.UtcNow);
                //}​​​​​
            }



            else
            {
                sw = File.AppendText(filePath);
                sw.WriteLine(message + DateTime.UtcNow);
            }
        }
       
    }
}
