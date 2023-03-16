using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Factorial
    {
        public static void Factors()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {n}! = {factorial}");
        }
    }
}
