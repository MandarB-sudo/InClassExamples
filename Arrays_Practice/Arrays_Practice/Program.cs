using System;

namespace Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IDs = { 111, 222, 333, 444 };
            int[] score = new int[4];
            score[0] = 45;
            score[1] = 55;
            score[2] = 66;
            score[3] = 77;



            for (int i = 0; i < IDs.Length; i++)
            {
                Console.WriteLine("Please enter the name of the student ");
                string name = Console.ReadLine();
            }

            
            for (int i = 0; i < IDs.Length; i++)
            {
                int studentid = IDs[i];

                int scoreof = score[i];

                Console.WriteLine($"{IDs[i]} + {score[i]}");
            }

                

            
            
                

           
            


        }
    }
}
