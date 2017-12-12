using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKm = fuelPerKm;
            this.Distance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelPerKm { get; set; }

        public int Distance { get; set; }

        internal void Drive(int travelDistance)
        {
            var needfuel = this.FuelPerKm * travelDistance;

            if (needfuel > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= needfuel;
                this.Distance += travelDistance;
            }
        }
    }
}
