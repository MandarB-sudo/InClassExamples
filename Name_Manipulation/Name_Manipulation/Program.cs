using System;

namespace Name_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "mANDAR";

            Console.WriteLine(firstname);

            firstname = " " + firstname.ToUpper()[0] + firstname.Substring(1);
            Console.WriteLine(firstname);

            Console.WriteLine("Please enter your full name ");
            string name = Console.ReadLine();
            string fname =  name.ToUpper()[0] + name.Substring(1, name.IndexOf(' '));
            string middle = name.Substring(name.IndexOf(' ') , name.IndexOf(' ')).ToUpper();
            string lname = name.Substring(name.IndexOf(' ')+1).ToUpper();

            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(middle);
            
            
        }
    }
}
