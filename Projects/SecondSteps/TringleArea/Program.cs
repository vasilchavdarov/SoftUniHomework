using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TringleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Double.Parse(Console.ReadLine());
            var h = Double.Parse(Console.ReadLine());
            var area = Math.Round(a * h / 2, 2);

            Console.WriteLine(area);

        }
    }
}
