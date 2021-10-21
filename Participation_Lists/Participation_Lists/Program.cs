using System;
using System.Collections.Generic;
namespace Participation_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            List<string> myList = new List<string>();
            do
            {



                Console.WriteLine("Please input the Grade you got ");
                double grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you have any more grades to enter");
                ans = Console.ReadLine();
                myList.Add(grade);

            } while (ans == "No");
        }
    
    
    }
}
