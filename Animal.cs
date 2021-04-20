using System;
using System.Collections.Generic;
using System.Text;

namespace DOGConsoleApp1
{
    public class Animal 
    {
        private int Age;
        private bool Domestic;

        public Animal()
        {

        }

        public Animal(int age,bool domestic)
        {
            Age = age;
            Domestic = domestic;

        }

        public void eat(string food)
        {
            Console.WriteLine($"my fav food is {food}");
        }

        //public void display()
        //{
        //    Console.WriteLine("Animal Age is : "+age);
        //    Console.WriteLine("Animal Age is : " + age);
        //}
    }
}
