using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public string Brand { get { return this.brand; } }
    public string Model { get { return this.model; } }
    public int YearOfProduction { get { return this.yearOfProduction; } }
    public int HorsePower
    {
        get
        {
            return this.horsepower;
        }
        set
        {
            this.horsepower = value;
        }
    }
    public int Acceleration { get { return this.acceleration; } }
    public int Suspension
    {
        get
        {
            return this.suspension;
        }
        set
        {
            this.suspension = value;
        }
    }
    public int Durability { get { return this.durability; } }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{brand} {model} {yearOfProduction}");
        sb.AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s");
        sb.AppendLine($"{suspension} Suspension force, {durability} Durability");

        return sb.ToString();
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.HorsePower += tuneIndex;
        this.Suspension += tuneIndex / 2;
    }
}
