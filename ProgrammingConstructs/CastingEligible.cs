using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class CastingEligible
    {

        public static void EligiblityCheck()
        {
            Console.WriteLine("Enter the Age to Check");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 )
            {
                Console.WriteLine("Candidate is Eligible for casting");
            }
            else
            {
                Console.WriteLine("Candidate is not Eligible for casting");
            }
        }
    }
}
