using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> scores = new List<double>();
            string ans;
            do
            {

                Console.WriteLine("Please enter the score");
                double score = Convert.ToDouble(Console.ReadLine());
                scores.Add(score);

                Console.WriteLine("Would you like to add another score ?");
                ans = Console.ReadLine();

                
            } while (ans.ToUpper()== "YES");

            foreach (double score in scores)
            {
                Console.WriteLine(score);
            }

            for (int i = 0; i < scores.Count; i+=2)
            {
                Console.WriteLine(scores[i]);
            }


            Random rand = new Random();
            int count = rand.Next(0, scores.Count);
            Console.WriteLine(scores);

        }
    }
}
