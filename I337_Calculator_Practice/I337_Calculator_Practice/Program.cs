using System;



//          A	4
 // E 3
//H | -|
//S   $
//T 7
//U | _ |
//O   0(this is the # 0)
//P    []D
//
//
//
//
//
//
//

namespace I337_Calculator_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Sentence ");
            string sentence = Console.ReadLine();
            sentence = sentence.ToUpper();

            sentence = sentence.Replace("A","4").Replace('E', '3').Replace("H","|-|").Replace('S', '$').Replace('T', '7')
                        .Replace("U","|_|").Replace('O', '0').Replace("P","[]D");
            Console.WriteLine(sentence);
            
        }
    }
}
