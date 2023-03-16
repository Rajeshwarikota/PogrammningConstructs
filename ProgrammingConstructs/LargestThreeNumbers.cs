using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class LargestThreeNumbers
    {
        public static void LargestNumbers() 
        {
            Console.WriteLine("Enter the First Integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Integer");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The Largest Value is " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Largest Value is " + num2);
            }
            else 
            {
                Console.WriteLine("The Largest Value is " + num3);
            }

        }
    }
}
