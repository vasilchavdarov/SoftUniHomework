using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniorscount = double.Parse(Console.ReadLine());
            var seniorscount = double.Parse(Console.ReadLine());
            var layout = Console.ReadLine().ToLower();

            if (layout == "trail")
            {
                var money = (juniorscount * 5.50) + (seniorscount * 7.00);
                var expense = money * 5 / 100;
                var totalmoney = money - expense;
                Console.WriteLine("{0:F2}",totalmoney);
            }
            else if (layout == "downhill")
            {
                var money = (juniorscount * 12.25) + (seniorscount * 13.75);
                var expense = money * 5 / 100;
                var totalmoney = money - expense;
                Console.WriteLine("{0:F2}", totalmoney);
            }
            else if (layout == "road")
            {
                var money = (juniorscount * 20.00) + (seniorscount * 21.50);
                var expense = money * 5 / 100;
                var totalmoney = money - expense;
                Console.WriteLine("{0:F2}", totalmoney);
            }
            else
            {
                var racers = juniorscount + seniorscount;

                if (racers < 50)
                {
                    var money = (juniorscount * 8.00) + (seniorscount * 9.50);
                    var expense = money * 5 / 100;
                    var totalmoney = money - expense;
                    Console.WriteLine("{0:F2}", totalmoney);
                }
                else
                {
                    var newtaxjuniors = 8.00 - (8.00 * 25 / 100);
                    var newtaxseniors = 9.50 - (9.50 * 25 / 100);

                    var money = (juniorscount * newtaxjuniors) + (seniorscount * newtaxseniors);
                    var expense = money * 5 / 100;
                    var totalmoney = money - expense;
                    Console.WriteLine("{0:F2}", totalmoney);
                }
            }
        }
    }
}
