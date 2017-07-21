using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());
            var weekendsInSofia = 48 - weekends;
            var gamesInsofia = weekendsInSofia * 3 / 4  ;
            var gamesInTown = weekends;
            var gamesHolidays = holidays * 2 / 3;
            var totalgames = gamesHolidays + gamesInsofia + gamesInTown;

            if (year == "leap")
            {
                var gamesleap = totalgames * 0.15;
                var gamestotal = gamesleap + totalgames;
                gamestotal = Math.Floor(gamestotal);
                Console.WriteLine(gamestotal);
            }
            else
            {
                totalgames = Math.Floor(totalgames);
                Console.WriteLine(totalgames);
            }


        }
    }
}
