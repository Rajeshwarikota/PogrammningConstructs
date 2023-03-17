using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumOfFirstFive
    {
        public static void Sum()
        {
            int num = 1;
            int sum = 0;
            int count = 0;

            while (count < 5)
            {
                sum += num;
                num++;
                count++;
            }

            Console.WriteLine("The sum of the first 5 natural numbers is: " + sum);
        }
    }
}
