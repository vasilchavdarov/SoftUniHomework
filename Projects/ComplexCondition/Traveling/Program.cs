using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            //: „summer” или “winter”   Balkans Europe      Bulgaria
            

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    var spentmoney = Math.Round(budget * 0.30, 2);
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - " + "{0:00.00}",spentmoney);
                }
                else
                {
                    var spentmoney = Math.Round(budget * 0.70, 2);
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - " + "{0:00.00}", spentmoney);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    var spentmoney = Math.Round(budget * 0.40, 2);
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - " + "{0:00.00}", spentmoney);
                }
                else
                {
                    var spentmoney = Math.Round(budget * 0.80, 2);
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - " + "{0:00.00}", spentmoney);
                }
            }
            else
            {
                var spentmoney = Math.Round(budget * 0.90, 2);
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - " + "{0:00.00}", spentmoney);
            }
        }
    }
}
