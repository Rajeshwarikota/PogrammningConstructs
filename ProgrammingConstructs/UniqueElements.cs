using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class UniqueElements
    {
        public static void Elements() 
        {
            Console.WriteLine("How many elents to add into array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("storing elements into array");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The unique elements in the array are:");
            foreach (int item in arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (item == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(item + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
