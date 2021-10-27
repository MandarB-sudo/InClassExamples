using System;
using System.IO;

namespace Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesoffile = File.ReadAllLines("sales_data_sample(1).csv");
            double totalsales = 0;
            double totalsales2003 = 0, totalsales2004 = 0, totalsales2005 = 0;
            double[] monthtotals = new double[13];


            for (int i = 1; i < linesoffile.Length; i++)
            {

                string line = linesoffile[i];

                string[] peicesofline = line.Split(',');


                string status = peicesofline[6];

                double sales = Convert.ToDouble(peicesofline[4]);
                int year = Convert.ToInt32(peicesofline[9]);
                int month = Convert.ToInt32(peicesofline[8]);


                if (status.ToLower() == "shipped") 
                {
                    if (year == 2003)
                    {
                        totalsales2003 += sales;
                    }

                    else if (year == 2004)
                    {
                        totalsales2004 += sales;
                    }
                    else if (year == 2005)
                    {
                        totalsales2005 += sales;
                    }

                    monthtotals[month] += sales;
                    totalsales += sales;

                    Console.WriteLine($"The total sales for the year 2003 is {totalsales2003.ToString("N2")}");
                    Console.WriteLine($"The total sales for the year 2004 is {totalsales2004.ToString("N2")}");
                    Console.WriteLine($"The total sales for the year 2005 is {totalsales2005.ToString("N2")}");
                }





            }




        }

    }
}
