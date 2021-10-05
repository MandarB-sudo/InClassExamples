using System;
using System.Collections.Generic;
namespace Collection_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> studentrecords = new Dictionary<int, double>();
            studentrecords.Add(1, 2.5);
            studentrecords.Add(2, 3.5);
            studentrecords.Add(3, 4.0);
            Console.WriteLine("Which student you want to see the gpa of ?");

            int studentid = Convert.ToInt32(Console.ReadLine());



            foreach (int id in studentrecords.Keys)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine();
            string answer;
            do
            {
                Console.WriteLine("Do you want to add another student to our records? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");
            if (studentrecords.ContainsKey(studentid) == true)
            {
                Console.WriteLine($"{studentrecords[studentid].ToString("N")}");
            }
            else
            {
                Console.WriteLine($" The student with {studentid} is not on the list");
            }
        }
    }
}
