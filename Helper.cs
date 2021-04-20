using System;
using System.Collections.Generic;
using System.Text;

namespace TaskConsoleApp1.Utility
{
    class Helper
    {

        //creating method using helperclass
        public static int RandomChoice(int length)
        {
            int startValue = 1;

            //using the Random class from classLibrary to generate random Numbers

            Random choice = new Random();

            //using the Next() method to generate random numbers between the min and max value
            int value = choice.Next(startValue, length);

            Console.WriteLine("generated random value is :"+value);

            return value;

        }
       
         
    }
}
