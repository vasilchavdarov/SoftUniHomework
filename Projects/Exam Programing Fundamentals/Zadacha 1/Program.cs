using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingsFlaps = int.Parse(Console.ReadLine());
            var distanceFor1000Wings = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var metersFly = (wingsFlaps / 1000) * distanceFor1000Wings;
            var secondsFlyWings = wingsFlaps / 100;
            var secondsRest = (wingsFlaps / endurance) * 5;
            var totalSeconds = secondsFlyWings + secondsRest;

            Console.WriteLine($"{metersFly:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");

        }
    }
}
