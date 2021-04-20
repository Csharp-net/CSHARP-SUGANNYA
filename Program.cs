using System;

namespace ZooAssesment
{
    class Program
    {
        public static void checkOccurence(char[] char1)
        {
            

                int zCount = 0;
                int oCount = 0;

                for (int i = 0; i < char1.Length; i++)
                {
                    if (char1[i] == 'z')
                    {
                        zCount = zCount + 1;

                    }
                    else if (char1[i] == 'o')
                    {
                        oCount = oCount + 1;
                    }
                }
                Console.WriteLine("zcount is" + zCount);
                Console.WriteLine("ocount is" + oCount);

                zCount = 2 * zCount;
                if (zCount == oCount)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                Console.WriteLine("Noo");

                }

            
            
           
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first word");

            string input1 = Console.ReadLine();

            
            if (input1.Length > 0 && input1.Length < 20)
            {

                char[] char1 = input1.ToLower().ToCharArray();
                checkOccurence(char1);
            }
            else
            {
                Console.WriteLine("invalid inputs");
            }

           

        }
    }
}
