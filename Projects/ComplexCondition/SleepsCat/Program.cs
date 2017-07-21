using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepsCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());
            var day = 365 - holidays;
            var timeforplay = (day * 63) + (holidays * 127);
            var timediference = Math.Abs(30000 - timeforplay);
            var hours = Math.Abs (timediference / 60);
            var min =Math.Abs (timediference % 60);

            if (timeforplay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min);
            }
            
        }
    }
}
