using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Speed_Racing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var model = line[0];
                var fuelAmount = double.Parse(line[1]);
                var fuelPerKm = double.Parse(line[2]);

                var car = new Car(model, fuelAmount, fuelPerKm);
                cars.Add(model, car);
            }

            string line2;
            while ((line2 = Console.ReadLine()) != "End")
            {
                var tokens = line2.Split(' ');
                var model = tokens[1];
                var travelDistance = int.Parse(tokens[2]);

                if (cars.ContainsKey(model))
                {
                    cars[model].Drive(travelDistance);
                }

            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
