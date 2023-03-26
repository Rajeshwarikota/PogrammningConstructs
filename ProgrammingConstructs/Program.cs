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

            Console.WriteLine("\n1:EqualityCheck\n2:EvenOrNot\n3:CatingEligibility\n4:LargestThreeNumbers\n5:AdmissionEntry\n6:WeekDays\n7:ArithmeticOperation\n8:PowerOfTwo\n9:SumOfSquares\n10:Factorial\n11:FlipCoin\n12:WordReverse\n13:SumOfFirstFive\n14:CountDuplicate\n15:finfing max or min\n16:Reverse triangle pattern\n17:ReversingNumber\n18:Sum of Digits\n19:Unique Elements\n22:Exit");
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
                case 14:
                    Console.WriteLine("How many elents to add into array");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[n];
                    Console.WriteLine("storing elements into array");

                    for (int i = 0; i < n; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    CountOfDuplicate.Duplicate(array);
                    break;
                case 15:
                    Console.WriteLine("How many elents to add into array");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[num];
                    Console.WriteLine("storing elements into array");

                    for (int i = 0; i < num; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    FindingMaxOrMin.MaxOrMin(arr);
                    break;
                case 16:
                    ReverseTrianglePattern.Reversetriangle();
                    break;
                case 17:
                    ReversingNumber.ReverseNumber();
                    break;
                case 18:
                    SumOFNumbers.DigitsSum();
                    break;
                case 19:
                    UniqueElements.Elements();
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
