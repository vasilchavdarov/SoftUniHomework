using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubing_In_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var hour = Double.Parse(Console.ReadLine());

            var litriP1 = p1 * hour;
            var litriP2 = p2 * hour;
            var water = litriP2 + litriP1;

            if (v >= water)
            {
                var poolfull = Math.Truncate((water * 100) / v);
                var p1full = Math.Truncate((litriP1 * 100) / (litriP1 + litriP2));
                var p2full = Math.Truncate((litriP2 * 100) / (litriP1 + litriP2));
              

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolfull, p1full, p2full);

            }
            else  //(v < litriP1 + litriP2)
            {
                var overpool = (litriP1 + litriP2) - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour, overpool);
            }
        }
    }
}
