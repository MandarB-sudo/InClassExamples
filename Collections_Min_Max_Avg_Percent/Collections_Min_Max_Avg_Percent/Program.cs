using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg_Percent
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            List<double> grades = new List<double>();

            do
            {
                Console.WriteLine("Please enter your grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);


                Console.WriteLine("Would you like to add another ?");
                ans = Console.ReadLine();

                    



            } while (ans.ToLower() == "yes");

            double max = grades[0];
            double min = grades[0];
            double sum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                double grade = grades[i];

                if (grade< min)
                {
                    min = grade;
                }
                else if  (grade > max)
                {
                    max = grade;
                }

                sum += grade;



            }
            double average = sum / grades.Count;
            Console.WriteLine($"The max score you recieved is {max.ToString("P1")}");
            Console.WriteLine($"The min score you recieved is {min.ToString("P1")}");
            Console.WriteLine($"The average score of your grades is {average.ToString("P1")}");




        }
    }
}
