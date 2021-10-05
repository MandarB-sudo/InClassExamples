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
