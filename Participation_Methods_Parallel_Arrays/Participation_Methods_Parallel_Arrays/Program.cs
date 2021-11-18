using System;
using System.Collections.Generic;
namespace Participation_Methods_Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentnames = { "Mandar", "Andrew", "Mahesh", "Camilo", "Brian" };
            int[] IDS = { 1, 2, 3, 4, 5 };
            List<List<double>> grades = new List<List<double>>();
            grades.Add(CreateRandoSizedListwithRandomValue());
            grades.Add(CreateRandoSizedListwithRandomValue());
            grades.Add(CreateRandoSizedListwithRandomValue());
            grades.Add(CreateRandoSizedListwithRandomValue());
            grades.Add(CreateRandoSizedListwithRandomValue());

        }
        static List<double> CreateRandoSizedListwithRandomValue()
        {
            List<double> randoGrades = new List<double>();
            Random rand = new Random();
            int numberofGrades = rand.Next(3, 7);
            for (int i = 0; i < numberofGrades; i++)
            {
                double grade = rand.NextDouble() * 100;
                randoGrades.Add(grade);
            }
            return randoGrades;

        }
        static void StudentInformation(string studentname, int id, List<double> grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            double avg = sum / grades.Count;
            Console.WriteLine($"{studentname} ({id} has {grades.Count.ToString("n")}");


        }

            
                
            
       






           





        }
    }
}
