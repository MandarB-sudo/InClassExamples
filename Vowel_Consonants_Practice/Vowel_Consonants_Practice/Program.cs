using System;

namespace Vowel_Consonants_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowelcount = 0;
            int consonantscount = 0;
            Console.WriteLine("Please input a sentence ");
            string sentence = Console.ReadLine();

            char letter;
            for (int i = 0; i < sentence.Length-1; i++)
            {
                letter = sentence[i];

                if (letter == 'a'|| letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelcount++;
                }

                else if(letter == ' ' || letter == '?' || letter == '.' || letter == ';' || letter == '!'|| letter == ',' || letter == '"')
                {
                    consonantscount = consonantscount + 0;
                }
                else
                {
                    consonantscount++;
                }
                
                

                
            }
            Console.WriteLine($"There are {vowelcount} vowels in the sentence ");
            Console.WriteLine($"There are {consonantscount} consonants in the sentence");
        }
    }
}
