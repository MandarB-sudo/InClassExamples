using System;

namespace Parallel_Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[3];
            double var1, var2, var3;
            const int multivalue = 790;
            double totalvalue = 0;
            Console.WriteLine("Input three numbers of your choice ");
            var1 = Convert.ToDouble(Console.ReadLine());
            var2 = Convert.ToDouble(Console.ReadLine());
            var3 = Convert.ToDouble(Console.ReadLine());

            array[0] = var1;
            array[1] = var2;
            array[2] = var3;


            for (int i = 0; i < array.Length-1; i++)
            {
                totalvalue = array[i] * multivalue;
            }
            Console.WriteLine($" the value is {totalvalue.ToString("N2")}");





        }
        
    }
}
