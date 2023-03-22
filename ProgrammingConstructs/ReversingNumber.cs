using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    class ReversingNumber
    {
        public static void ReverseNumber()
        {
            int num, remainder, reverse = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Reversed number is" + reverse);

        }
    }
}
