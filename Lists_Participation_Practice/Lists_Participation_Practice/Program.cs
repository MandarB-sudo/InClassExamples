using System;
using System.Collections.Generic;

namespace Lists_Participation_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gradeslist = new List<double>();

            
            string answer;
            double average ;
            double sum = 0;
            do
            {
                Console.WriteLine("Please enter the grade for  your subject ?");
                 double grade = Convert.ToDouble(Console.ReadLine());
                gradeslist.Add(grade);

                Console.WriteLine("Would you like to add another grade ?");
                 answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            foreach (double grade in gradeslist)
            {
                sum += grade;
            }
            Console.WriteLine($"The average of all the grades is {(sum/gradeslist.Count).ToString("P")}");
        }
    }
}
