using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var mackerelprice = double.Parse(Console.ReadLine());
            var spratprice = double.Parse(Console.ReadLine());
            var palamudkg = double.Parse(Console.ReadLine());
            var scadkg = double.Parse(Console.ReadLine());
            var clamskg = int.Parse(Console.ReadLine());

            var palamudprice = mackerelprice + (mackerelprice * 60 / 100);
            var scadprice = spratprice + (spratprice * 80 / 100);
            var clamsprice = 7.50;

            var totalprice = (palamudkg * palamudprice) + (scadkg * scadprice) + (clamskg * clamsprice);

            Console.WriteLine("{0:F2}",totalprice);


        }
    }
}
