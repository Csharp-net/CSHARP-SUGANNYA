using System;
using System.Collections.Generic;
using System.Text;
using ApartmentDemo;

namespace ApartmentDemo
{
    class Location : Apartment
    {
        string streetName;
        string city;

        public Location() : base()
        {

            streetName = "Balkan";
            city = "street Excellence";
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public void locationInfo()
        {
            Console.WriteLine("Apartment " + apartmentNo + "has located in" + streetName + "" + city);
        }

    }
}
