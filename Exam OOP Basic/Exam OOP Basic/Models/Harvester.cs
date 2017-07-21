using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        set
        {
            if (value > 0 && value < 20000)
            {
                energyRequirement = value;
            }
            else
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");

            }

        }
    }


    public double OreOutput
    {
        get { return oreOutput; }
        set
        {
            if (value > 0)
            {
                oreOutput = value;
            }
            else
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }

        }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}

