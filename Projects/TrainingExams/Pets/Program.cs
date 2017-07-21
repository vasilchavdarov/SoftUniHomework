using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodkg = int.Parse(Console.ReadLine());
            var dogfoodkgforday = double.Parse(Console.ReadLine());
            var catfoodkgforday = double.Parse(Console.ReadLine());
            var turtlefoodgramforday = double.Parse(Console.ReadLine());

            var turtlefoodkg = turtlefoodgramforday / 1000;

            var petseatfood = (dogfoodkgforday + catfoodkgforday + turtlefoodkg) * days;

            if (foodkg >= petseatfood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(foodkg - petseatfood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(petseatfood - foodkg));
            }


        }
    }
}
