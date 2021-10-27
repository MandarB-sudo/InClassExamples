using System;
using System.IO;

namespace Homework_5_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namelines = File.ReadAllLines("CustomerNames.csv");
            string[] accountbalances = File.ReadAllLines("AccountBalances.csv");
            string[] customernames = new string[1000];
            double[] balance = new double[1000];

            for (int i = 1; i < namelines.Length; i++)
            {

                if (string.IsNullOrWhiteSpace(namelines[i]) == true)
                {
                    continue;
                }
                else
                {
                    customernames[i - 1] = namelines[i];
                    string bal = accountbalances[i];
                    bal = bal.Replace('$', ' ');
                    balance[i - 1] = Convert.ToDouble(bal);
                }
                


            }


            foreach (string name in customernames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Whose balance would you like to see ?");
            string ans = Console.ReadLine();

            for (int i = 0; i < customernames.Length; i++)
            {
                if (ans.ToLower()  == customernames[i])
                {
                    Console.WriteLine($" {ans} has a balance of {balance}");
                }
                
            }

            
            
            

        }
    }
}
