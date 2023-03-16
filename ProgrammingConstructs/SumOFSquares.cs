using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumOFSquares
    {
        public static void Squres()
        {
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"The sum of squares of {n} numbers starting from 1 is {sum}.");
        }
    }
}
