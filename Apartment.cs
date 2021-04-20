using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentDemo

{
    public class Apartment
    {
        public string apartmentNo;
        public string buildingNo;
        public string Floor;
        private string ownerName = "xyz";

        
        public void displayInfo()
        {
            Console.WriteLine("Enter  the Apartment No");
            apartmentNo = Console.ReadLine();
            Console.WriteLine("Enter  the Building No");
            buildingNo = Console.ReadLine();
            Console.WriteLine("Enter  the Floor No");
            Floor = Console.ReadLine();
            //Console.WriteLine("Enter  the ownerName");
            //ownerName = Console.ReadLine();


        }

        //public string OwnerName
        //{
        //    get
        //    {
        //        return ownerName;
        //    }
        //    set
        //    {
        //        ownerName = value;
        //    }

        //}
        public void getDetails()
        {

            Console.WriteLine("Apartment No is : " + apartmentNo);
            Console.WriteLine("Building No is :" + buildingNo);
            Console.WriteLine("Floor No is :" + Floor);
            Console.WriteLine("Owner Name is :" + ownerName);



        }


    }
}
