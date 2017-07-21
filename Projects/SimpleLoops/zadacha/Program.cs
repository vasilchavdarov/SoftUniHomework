using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var delitetby2 = 0.0;
            var delitetby3 = 0.0;
            var delitetby4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    delitetby2++;
                }

                if (number % 3 == 0)
                {
                    delitetby3++;
                }

                if (number % 4 == 0)
                {
                    delitetby4++;
                }
            }
            var p1 = delitetby2 / n * 100;
            var p2 = delitetby3 / n * 100;
            var p3 = delitetby4 / n * 100;

            Console.WriteLine("{0:f2}%",p1);
            Console.WriteLine("{0:f2}%",p2);
            Console.WriteLine("{0:f2}%",p3);
        }
    }
}
