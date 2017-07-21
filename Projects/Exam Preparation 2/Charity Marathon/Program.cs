using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = double.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var lapLenghtInMeter = double.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var totalCapacity = trackCapacity * marathonDays;
            var totalMeter = lapLenghtInMeter * laps;
            var totalMoney = 0.0;

            if (runners < totalCapacity)
            {
                var totalKilometer = (runners * totalMeter) / 1000;
                totalMoney = totalKilometer * moneyPerKilometer;
            }
            else
            {
                var totalKilometer = (totalCapacity * totalMeter) / 1000;
                totalMoney = totalKilometer * moneyPerKilometer;
            }

            Console.WriteLine("Money raised: {0:f2}",totalMoney);
        }
    }
}
