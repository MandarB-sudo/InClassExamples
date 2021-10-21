using System;

namespace Participation_Practice_Strings_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(sentence);
            Console.WriteLine("What word would you like to look for in the above sentence ?");
            string wordserach = Console.ReadLine();
            Console.WriteLine("What word would you like to replace it to ?");
            string wordreplace = Console.ReadLine();

            if (sentence.Contains(wordserach) == true)
            {
                string newsentence = sentence.Replace(wordserach, wordreplace);
                Console.WriteLine(newsentence);
            }
            else
            {
                Console.WriteLine($"Sorry , could not find {wordserach} in the sentence ");

                string reverse = "";
                for (int i = wordreplace.Length-1; i >= 0; i--)
                {


                    reverse += wordreplace[i];
                    
                    
                }
                Console.WriteLine(reverse);
                

                
            }
        }
    }
}
