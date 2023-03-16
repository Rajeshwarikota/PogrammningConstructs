using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class PowerOfTwo
    {
        public static void Power()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Powers of 2 that are less than or equal to 2^n:");

            for (int i = 0; i <= n; i++)
            {
                int powerOfTwo = (int)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {powerOfTwo}");
            }
        }
    }
}
