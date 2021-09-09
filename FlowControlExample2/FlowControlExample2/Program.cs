using System;

namespace FlowControlExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randvalue = rand.Next(1, 101);
            if (randvalue % 3==0 && randvalue % 5 ==0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (randvalue % 5 ==0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randvalue % 3 ==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randvalue);
            }
        }
    }
}
