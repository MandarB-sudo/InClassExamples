using System;
using System.Collections.Generic;

namespace collection_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoritethings = new List<string>();

            do
            {

                Console.WriteLine("Tell me your favorite things to add to my list>>");
                string favoritething = Console.ReadLine();

                favoritethings.Add(favoritething);

                Console.WriteLine("Do you have another favortie thing to add ? yes or no>>");

            } while (Console.ReadLine().ToLower() =="yes");
            Random rand = new Random();
            int randomindex = rand.Next(0, favoritethings.Count);
        }
    }
}
