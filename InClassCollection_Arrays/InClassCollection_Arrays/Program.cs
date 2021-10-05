using System;

namespace InClassCollection_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIDs = { 1, 2, 3 };
            double[] Gpas = new double[3];
            Gpas[0] = 2.5;
            Gpas[1] = 3.5;
            Gpas[2] = 4.0;

            Console.WriteLine("Which student do you want to see the gpa of ?");
            int studentid = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < studentIDs.Length; i++)
            {
                int id = studentIDs[i];
                double gpa = Gpas[i];
                if (id == studentid)
                {
                    Console.WriteLine($"{gpa.ToString("N")}");
                }
            }

        }
    }
}
