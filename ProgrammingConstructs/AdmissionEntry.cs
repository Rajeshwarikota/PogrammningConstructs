using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class AdmissionEntry
    {
        public static void AdmissionEligibility()
        {
            Console.WriteLine("Enter the marks in Physics:");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks in Chemistry:");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks  in Mathematics:");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = physicsMarks + chemistryMarks + mathMarks;

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks >= 65 && (physicsMarks >= 50 || chemistryMarks >= 50) && (mathMarks + physicsMarks + chemistryMarks >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
