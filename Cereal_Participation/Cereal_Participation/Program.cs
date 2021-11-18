using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
           string[]  CerealList =  File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> listofcereal = new List<Cereal>();
            for (int i = 1; i < CerealList.Length; i++)
            {
                string line = CerealList[i];
                string[] peicesofline = line.Split('|');


                string name = peicesofline[0];
                string manufacturer = peicesofline[1];
                double Calories = Convert.ToDouble(peicesofline[2]);
                double Cups = Convert.ToDouble(peicesofline[3]);

                Cereal cereal = new Cereal();
                cereal.Name = name;
                cereal.Manufacturer = manufacturer;
                cereal.Calories = Calories;
                cereal.Cups = Cups;

               
                listofcereal.Add(cereal);
                
            }
            foreach ( Cereal cereal in listofcereal)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);
                }
               
                if (cereal.Calories >= 100)
                {
                    Console.WriteLine(cereal);
                }
            }
            
        }
    }
}
