using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Programming Constructs....");

            Console.WriteLine("Enter the First Integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both the Integers are equal");
            }
            else 
            {
                Console.WriteLine("Both the Integers are not equal");
            }
            Console.ReadLine();
        }
    }
}
