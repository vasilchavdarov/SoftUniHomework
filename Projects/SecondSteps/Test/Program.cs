﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Double.Parse(Console.ReadLine());
            var y1 = Double.Parse(Console.ReadLine());
            var x2 = Double.Parse(Console.ReadLine());
            var y2 = Double.Parse(Console.ReadLine());
            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = a * b;
            var perimeter = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);


        }
    }
}
