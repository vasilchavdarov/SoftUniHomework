using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            ulong stepsSeconds = (ulong)steps * (ulong)secondsPerStep;
            var totalseconds = stepsSeconds % 86400;

            var endTime = startingTime.AddSeconds(totalseconds);

            var result = endTime.ToString("HH:mm:ss");

            Console.WriteLine($"Time Arrival: {result}");

        }
    }
}
