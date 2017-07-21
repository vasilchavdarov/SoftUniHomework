using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compane
{
    class Program
    {
        static void Main(string[] args)
        {
            var needtime = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var hoursforstady = (days * 0.10) * 8;
            var hourdays = (days * 8) - hoursforstady;
            var hoursplus = workers * 2 * days;
            var totalhours = hourdays + hoursplus;
            totalhours = Math.Floor(totalhours);

            if (totalhours >= needtime)
            {
                var lefttime = Math.Abs(totalhours - needtime);
                Console.WriteLine($"Yes!{lefttime} hours left.");
            }
            else
            {
                var lefttime = Math.Abs(totalhours - needtime);
                Console.WriteLine($"Not enough time!{lefttime} hours needed.");
            }
        }
    }
}
