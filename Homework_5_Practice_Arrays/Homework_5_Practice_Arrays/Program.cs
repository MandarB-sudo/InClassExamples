using System;
using System.IO;
namespace Homework_5_Practice_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] customernames = new string[5];
            double[] accountbalances = { 500.2, 4000.5, 56.45, 578, 700 };

            string cus1, cus2, cus3, cus4, cus5;
            

            Console.WriteLine("Please input the names of the customer");
            cus1 = Console.ReadLine();
            cus2 = Console.ReadLine();
            cus3 = Console.ReadLine();
            cus4 = Console.ReadLine();
            cus5 = Console.ReadLine();

            customernames[0] = cus1;
            customernames[1] = cus2;
            customernames[2] = cus3;
            customernames[3] = cus4;
            customernames[4] = cus5;

            string cnames;
            for (int i = 0; i < customernames.Length; i++)
            {
                 cnames = customernames[i];

                if (cnames.Contains(" ") == true)
                {
                    cnames.Trim(' ');

                    Console.WriteLine(cnames);
                }
                else
                {
                    Console.WriteLine(cnames);

                }

                
                }
            



            }

            









            }
        }
    }
}
