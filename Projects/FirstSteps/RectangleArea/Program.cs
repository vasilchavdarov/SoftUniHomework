using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Decimal.Parse(Console.ReadLine());
            var b = Decimal.Parse(Console.ReadLine());
            var area = a * b;
            Console.WriteLine(area);
        }
    }
}
