using System;
using System.Collections.Generic;

namespace Lists_Homework_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoritethings = new List<string>();
            string ans;
            do
            {
                Console.WriteLine("Please add your favorite thing ");
                string favorite = Console.ReadLine();
                favoritethings.Add(favorite);
                Console.WriteLine("Would you like to add another ?");
                 ans = Console.ReadLine();
            } while (ans.ToLower() == "yes");

            foreach (string favorite in favoritethings)
            {
                Console.WriteLine(favorite);
            }

            Console.WriteLine("List in reverse order");
            for (int i = favoritethings.Count-1 ; i >=0; i--)
            {
                Console.WriteLine(favoritethings[i]);
            }

            Console.WriteLine("List with every other item");

            for (int i = 0; i < favoritethings.Count; i = i+2)
            {
                Console.WriteLine(favoritethings[i]);
            }
        }

    }
}
