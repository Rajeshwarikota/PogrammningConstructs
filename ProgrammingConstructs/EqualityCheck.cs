﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    class EqualityCheck
    {
        public static void Check()
        { 
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
        }
    }
}
