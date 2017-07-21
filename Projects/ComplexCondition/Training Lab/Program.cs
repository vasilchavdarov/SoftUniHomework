using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var hsm = h * 100;
            var wsm = w * 100;
            var hseads = Math.Truncate (hsm / 120);
            var wseads = Math.Truncate ((wsm - 100) / 70);
            var seads = (hseads * wseads) - 3;

            Console.WriteLine(seads);
        }
    }
}
