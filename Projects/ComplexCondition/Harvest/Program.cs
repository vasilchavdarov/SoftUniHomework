using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var harvest = int.Parse(Console.ReadLine());
            var grapes = double.Parse(Console.ReadLine());
            var wine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapeformharvest = harvest * grapes;
            var grapeforwine = grapeformharvest * 0.40;
            var literswine = (grapeforwine / 2.5);
            

            if (literswine < wine)
            {
                var overwine = Math.Abs(literswine - wine);
                overwine = Math.Truncate(overwine);
                Console.WriteLine($"It will be a tough winter! More {overwine} liters wine needed.");
            }
            else
            {
                var overwine = Math.Abs(literswine - wine);
                overwine = Math.Ceiling(overwine);
                var wineforperson = overwine / workers;
                wineforperson = Math.Ceiling(wineforperson);
                literswine = Math.Floor(literswine);
                Console.WriteLine($"Good harvest this year! Total wine: {literswine} liters.");
                Console.WriteLine($"{overwine} liters left -> {wineforperson} liters per person.");
                
            }
        }
    }
}
