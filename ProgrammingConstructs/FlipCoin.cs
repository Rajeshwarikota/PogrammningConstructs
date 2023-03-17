using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class FlipCoin
    {
        public static void Flip()
        {
            Random rand = new Random();
            int headsCount = 0;
            int tailsCount = 0;

            while (headsCount <= 20 && tailsCount <= 20)
            {
                int coinFlip = rand.Next(2);
                if (coinFlip == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads!");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails!");
                }
            }

            if (headsCount == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }
    }
}
 