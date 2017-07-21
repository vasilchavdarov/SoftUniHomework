using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallroom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var bathroom = smallroom / 2;
            var secondroom = smallroom + (smallroom * 10 / 100);
            var lastroom = secondroom + (secondroom * 10 / 100);

            var area = smallroom + kitchen + bathroom + secondroom + lastroom;
            area = area + (area * 5 / 100);

            var totalprace = area * price;

            Console.WriteLine("{0:F2}",totalprace);
        }
    }
}
