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

            Console.WriteLine("\n1:EqualityCheck\n2:EvenOrNot\n3:CatingEligibility\n4:LargestThreeNumbers\n5:AdmissionEntry\n6:WeekDays\n7:ArithmeticOperation\n8:PowerOfTwo\n9:SumOfSquares\n10:Factorial\n11:FlipCoin\n12:WordReverse\n13:SumOfFirstFive\n22:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    EqualityCheck.Check();
                    break;
                case 2:
                    EvenOrNot.EvenOrNotCheck(); 
                    break;
                case 3:
                    CastingEligible.EligiblityCheck();
                    break;
                case 4:
                    LargestThreeNumbers.LargestNumbers();
                    break;
                case 5:
                     AdmissionEntry.AdmissionEligibility();
                    break;
                case 6:
                    WeekDays.DaysCheck();
                    break;
                case 7:
                     ArithmeticOperations.Operations();
                    break;
                case 8:
                    PowerOfTwo.Power();
                    break;
                case 9:
                    SumOFSquares.Squres();
                    break;
                case 10:
                    Factorial.Factors();
                    break;
                case 11:
                    FlipCoin.Flip();
                    break;
                case 12:
                    WordReverse.Reverse();
                    break;
                case 13:
                    SumOfFirstFive.Sum();
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
