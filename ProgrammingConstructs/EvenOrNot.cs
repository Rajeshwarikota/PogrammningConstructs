using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EvenOrNot
    {
        public static void EvenOrNotCheck()
        {
            Console.WriteLine("Enter the Number to Check");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Given number is Even");
            }
            else 
            {
                Console.WriteLine("Given number is  not Even");
            }
        }
    }  
}
