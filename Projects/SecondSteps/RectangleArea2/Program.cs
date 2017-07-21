using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Double.Parse(Console.ReadLine());
            var y1 = Double.Parse(Console.ReadLine());
            var x2 = Double.Parse(Console.ReadLine());
            var y2 = Double.Parse(Console.ReadLine());
            var a = Math.Abs (x1 - x2);
            var b = Math.Abs (y1 - y2);
            var area = a * b;
            var perimeter = 2 * (a + b);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);

        }
    }
}
