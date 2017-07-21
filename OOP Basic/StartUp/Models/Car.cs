using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car : Vehicle
{
    private const double AcConsumation = 0.9;

    public Car(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumationPerKm + AcConsumation, tankCapacity)
    {
    }

    public override double FuelQuantity
    {

        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            base.FuelQuantity = value;
        }
    }
}
