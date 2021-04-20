using System;
using System.Collections.Generic;
using System.Text;

namespace DOGConsoleApp1
{
    public class Dog : Animal
    {
        public string name;
        public string breed;

        public Dog() : base()
        {

            name = "Balkan";
            breed = "street Excellence";
        }
        public Dog(string name, string breed, int age, bool domestic) : base(age, domestic)
        {
            this.Name = name;
            this.Breed = breed;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public void bark()
        {
            Console.WriteLine("Barkinggg");
        }

    }
}
