using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumationPerKm;
    private double tankCapacity;
    

    public Vehicle(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm;
    }

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    public double FuelConsumationPerKm
    {
        get { return this.fuelConsumationPerKm; }
        set { this.fuelConsumationPerKm = value; }
    }

    public virtual double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    protected virtual bool Drive(double distance, bool isAcOn)
    {
        var needFuel = distance * this.FuelConsumationPerKm;
        if (needFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= needFuel;
            return true;
        }
        return false;
    }

    public string TryTravelDistance(double distance, bool isAcOn)
    {
        if (this.Drive(distance, isAcOn))
        {
            return $"{this.GetType().Name} travelled {distance} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }

    public string TryTravelDistance(double distance)
    {
        return this.TryTravelDistance(distance, true);
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }


}
