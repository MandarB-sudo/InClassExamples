using System;
using System.Collections.Generic;

namespace Max_Min_Collections_P
{
    class Program
    {
        static void Main(string[] args)

            
        {
            List<double> grades = new List<double>();
            
            string answer;
            
            do
            {
                Console.WriteLine("Please enter the grade for your exam>>");
                double  grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);
                Console.WriteLine("Would you like to enter another ?");
                answer = Console.ReadLine();


            } while (answer == "Yes");

            double max = grades[0], min = grades[0], sum = 0;

            foreach (double grade in grades)
            {
                sum += grade;
                if (grade < min)
                {
                    min = grade;
                }
                if (grade > max)
                {
                    max = grade;
                }








            }
            double average = sum / grades.Count;

            Console.WriteLine($"The maximum grade you acheived is {max.ToString("P")}");
            Console.WriteLine($"The minimum grade you acheived is {min.ToString("P")}");
            Console.WriteLine($"The average of your grade is {average.ToString("N1")}");
            
        }
    }
}
