using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numb200 = 0.0;
            var numb400 = 0.0;
            var numb600 = 0.0;
            var numb800 = 0.0;
            var numb1000 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    numb200++;
                }

                if (number >= 200 && number < 400)
                {
                    numb400++;
                }

                if (number >= 400 && number < 600)
                {
                    numb600++;
                }

                if (number >= 600 && number < 800)
                {
                    numb800++;
                }

                if (number >= 800)
                {
                    numb1000++;
                }
            }
            var p1 = numb200 / n * 100;
            var p2 = numb400 / n * 100;
            var p3 = numb600 / n * 100;
            var p4 = numb800 / n * 100;
            var p5 = numb1000 / n * 100;

            Console.WriteLine("{0:F2}%",p1);
            Console.WriteLine("{0:F2}%",p2);
            Console.WriteLine("{0:F2}%",p3);
            Console.WriteLine("{0:F2}%",p4);
            Console.WriteLine("{0:F2}%",p5);

        }
    }
}
