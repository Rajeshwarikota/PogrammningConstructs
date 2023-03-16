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

            Console.WriteLine("\n1:EqualityCheck\n2:EvenOrNot\n22:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    EqualityCheck.Check();
                    break;
                case 2:
                    EvenOrNot.EvenOrNotCheck(); 
                    break;
            }
            Console.ReadLine();
        }
    }
}
