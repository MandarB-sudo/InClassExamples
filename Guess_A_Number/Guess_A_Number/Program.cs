using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            int maxint, minint;

           
            Console.WriteLine("Give me a max number");

            string max = Console.ReadLine();
            maxint  = Convert.ToInt32(max);

            Console.WriteLine(" Give me a min number ");
            string min = Console.ReadLine();
            minint = Convert.ToInt32(min);


            Console.WriteLine(" Guess a random number ");
            string random = Console.ReadLine();
            int guess = Convert.ToInt32(random);

           
           

           
           
            }
        }
    }
}
