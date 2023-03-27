using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumOfRow
    {
        int i, j;
        int[,] a = new int[20, 20];
        int rows;
        int coloumns;

        public void getmatrix()
        {
            Console.WriteLine("Enter The Number of Rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number of Columns : ");
            coloumns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= coloumns; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= coloumns; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void Display()
        {
            int r;
            for (i = 1; i <= rows; i++)
            {
                r = 0;
                for (j = 1; j <= coloumns; j++)
                {
                    r = r + a[i, j];
                }
                Console.WriteLine("{0} Row Sum : {1}", i, r);
            }
        }
    }
}

