using System;

namespace Participation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randvalue = rand.Next(1, 3);
            int guess;
            const string name = "Mandar";
            Console.WriteLine("Please choose between heads and tails ");
            string input = Console.ReadLine();
            
           

            if (input == "Heads")
            {
                guess = 1;
            }
            else
            {
                guess = 2;
            }

            

            if ( randvalue == 1  && randvalue == guess)
            {
                Console.WriteLine("The toss resulted in heads your guess was right");
            }
            else if (randvalue ==2 && randvalue == guess )
            {

                Console.WriteLine("The toss resulted in tails your guess was right");

            }
            else if (randvalue == 1 && randvalue != guess)
            {
                Console.WriteLine(" The toss resulted in heads but your guess was wrong");
            }
            else
            {
                Console.WriteLine(" The toss resulted in tails but your guess was wrong");
            }
            Console.WriteLine(name);
        }
    }
}
