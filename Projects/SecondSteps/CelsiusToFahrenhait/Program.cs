using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            // °F = °C × 1,8 + 32
            var c = Double.Parse(Console.ReadLine());
            var f = Math.Round(c * 1.8 + 32, 2);

            Console.WriteLine(f);

        }
    }
}
