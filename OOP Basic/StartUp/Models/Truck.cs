using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Truck : Vehicle
{
    private const double AcConsumation = 1.6;
    private const double FuelLost = 0.95;

    public Truck(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumationPerKm + AcConsumation, tankCapacity)
    {
    }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * FuelLost);
    }
}
