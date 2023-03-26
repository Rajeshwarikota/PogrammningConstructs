using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    class SumOFNumbers
    {
        public static void DigitsSum()
        {
            int num, digit,sum = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                digit = num % 10;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine("Sum of digits  is" + sum);
        }
    }
}
