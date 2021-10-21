using System;

namespace Participation_Methods_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mandar";
            string classname = "MIS3013";
            string date = "10/21/21";
            double val1, val2;
            string ans , loopans;
            do
            {
                Console.WriteLine("What kind of application would you like to perform ?");
                 ans = Console.ReadLine();
                Console.WriteLine("Please enter two values for the calculation");
                val1 = Convert.ToDouble(Console.ReadLine());
                val2 = Convert.ToDouble(Console.ReadLine());

                if (ans == "Add")
                {
                    Add(val1, val2);
                    Console.WriteLine(Add(val1,val2));
                }
                else if (ans == "Subtract")
                {
                    Console.WriteLine(Subtract(val1, val2));
                }
                else if (ans == "Multiply")
                {
                    Console.WriteLine(Multiply(val1, val2));
                }
                else if (ans == "Divide")
                {
                    Console.WriteLine(Divide(val1, val2));
                }
                Console.WriteLine("Do you want to do another run for a new calculatiion ?");
                loopans = Console.ReadLine();

                if (loopans == "No")
                {
                    Console.WriteLine($"Would you like to use the same numbers  ?");
                    ans = Console.ReadLine();
                    if (ans == "Yes")
                    {
                        Console.WriteLine("What kind of application would you like yo run ?");
                        ans = Console.ReadLine();
                        if (ans == "Add")
                        {
                            Add(val1, val2);
                            Console.WriteLine(Add(val1, val2));
                        }
                        else if (ans == "Subtract")
                        {
                            Console.WriteLine(Subtract(val1, val2));
                        }
                        else if (ans == "Multiply")
                        {
                            Console.WriteLine(Multiply(val1, val2));
                        }
                        else if (ans == "Divide")
                        {
                            Console.WriteLine(Divide(val1, val2));
                        }

                    }
                    Console.WriteLine("Would you like to exit ?");
                    ans = Console.ReadLine();
                    if (ans == "yes")
                    {
                        Environment.Exit(0);
                    }

                }



            } while (loopans == "Yes");

            




            DeveloperInformation(name, classname, date);

        }

        static double Add(double val1, double val2)
        {
            double sum = 0;
            sum = val1 + val2;
            return sum;
        }

        static double Subtract(double val1, double val2)
        {
            double minus = 0;
            minus = val1 - val2;

            return minus;
        }
        static double Multiply(double val1, double val2)
        {
            double Multi = 0;
            Multi = val1 * val2;

            return Multi;
        }
        static double Divide(double val1, double val2)
        {
            double div = 0;
            div = val1 / val2;

            return div;
        }
        static void DeveloperInformation(string name, string classname, string date)
        {
            Console.WriteLine($"The name of the developer is{name}");
            Console.WriteLine($" The class name of the developer is {classname}");
            Console.WriteLine($"The date the program wriiten is {date}");
        }
    }
}
