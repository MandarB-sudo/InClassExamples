using System;

namespace Flow_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my world application!, What is your name ? >>");
            string name = Console.ReadLine();
            Console.WriteLine("${name},what is your monthly income? >>");
            string monthlyIncomeAsString = Console.ReadLine();
            double monthlyIncome = Convert.ToDouble(monthlyIncomeAsString);
            Console.WriteLine("${name},what is your monthly expense? >>");
            string Monthlyexpenseasstring = Console.ReadLine();
            double monthlyexpense = Convert.ToDouble(Monthlyexpenseasstring);

            double monthlyNetIncome = monthlyIncome - monthlyexpense;





            if (monthlyNetIncome >= 0) ;
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red
            }
        }


    }
}
