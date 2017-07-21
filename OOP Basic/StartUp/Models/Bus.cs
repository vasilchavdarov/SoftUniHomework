using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bus : Vehicle
{
    private const double AcConsumation = 1.4;

    public Bus(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
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

    protected override bool Drive(double distance, bool isAcOn)
    {
        double requerFuel = 0;
        if (isAcOn)
        {
            requerFuel = distance * (this.FuelConsumationPerKm + AcConsumation);
        }
        else
        {
            requerFuel = distance * this.FuelConsumationPerKm;
        }

        if (requerFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= requerFuel;
            return true;
        }

        return false;
    }
}
