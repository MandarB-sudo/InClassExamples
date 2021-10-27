using System;

namespace Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IDs = new int[5];
            IDs[0] = 1000;
            IDs[1] = 2000;
            IDs[2] = 3000;
            IDs[3] = 4000;
            IDs[4] = 5000;

            Console.WriteLine("Enter name of five people ");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            string name4 = Console.ReadLine();
            string name5 = Console.ReadLine();

            string[] namearray = new string[5];
            namearray[0] = name1;
            namearray[1] = name2;
            namearray[2] = name3;
            namearray[3] = name4;
            namearray[4] = name5;


            for (int i = 0; i < IDs.Length; i++)
            {
                Console.WriteLine($"{IDs[i]} , {namearray[i]}");
            }


        }
    }
}
