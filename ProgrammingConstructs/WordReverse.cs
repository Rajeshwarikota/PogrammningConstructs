using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class WordReverse
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter the word to Reverse");
            String originalword = Console.ReadLine();
            string ReversedWord = "";
            char[] ch = originalword.ToCharArray();
            Array.Reverse(ch);
            string reverse = new String(ch);
            Console.WriteLine(reverse);


        }
    }
}
