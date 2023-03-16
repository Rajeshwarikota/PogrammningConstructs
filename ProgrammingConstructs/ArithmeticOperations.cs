using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class ArithmeticOperations
    {
        public static void Operations()
        {
            Console.WriteLine("Enter the First Integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double result = 0.0 ;

            Console.WriteLine("\n1:Addition\n2:Substraction\n3:Multiplication\n4:division\n22:Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"The difference of {num1} and {num2} is {result}.");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"The product of {num1} and {num2} is {result}.");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: division by zero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The quotient of {num1} and {num2} is {result}.");
                    }
                    break;
                
            }
            Console.ReadLine();
        }
    }
}
