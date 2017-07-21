using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DraftManager
{
    private string currentModeEnergy = "Full";
    private double totalEnergiProvided = 0;
    private double totalMinedPlumbusOre = 0;
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];

        try
        {
            Harvester currentHarvester = GetHarvester(arguments);
            this.harvesters.Add(id, currentHarvester);

            return $"Successfully registered {type} Harvester - {id}";

        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }


    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];

        try
        {
            Provider currentProvider = GetProvider(arguments);
            this.providers.Add(id, currentProvider);

            return $"Successfully registered {type} Provider - {id}";


        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string Day()
    {
        double energyProvidedPerDay = 0;
        double plumbusOreMined = 0;
        double needEnergy = 0;
        var sb = new StringBuilder();

        if (currentModeEnergy == "Full")
        {
            foreach (var provider in providers)
            {
                energyProvidedPerDay += provider.Value.EnergyOutput;
            }
            foreach (var harvester in harvesters)
            {
                needEnergy += harvester.Value.EnergyRequirement;
                plumbusOreMined += harvester.Value.OreOutput;
            }

            totalEnergiProvided += energyProvidedPerDay;
            if (totalEnergiProvided >= needEnergy)
            {
                totalEnergiProvided -= needEnergy;
                totalMinedPlumbusOre += plumbusOreMined;
            }
            else
            {
                plumbusOreMined = 0;
            }
        }
        else if (currentModeEnergy == "Half")
        {
            foreach (var provider in providers)
            {
                energyProvidedPerDay += provider.Value.EnergyOutput;
            }
            foreach (var harvester in harvesters)
            {
                needEnergy += (harvester.Value.EnergyRequirement / 100) * 60;
                plumbusOreMined += (harvester.Value.OreOutput / 2);
            }

            totalEnergiProvided += energyProvidedPerDay;
            if (totalEnergiProvided >= needEnergy)
            {
                totalEnergiProvided -= needEnergy;
                totalMinedPlumbusOre += plumbusOreMined;
            }
            else
            {
                plumbusOreMined = 0;
            }
        }
        else if (currentModeEnergy == "Energy")
        {
            foreach (var provider in providers)
            {
                energyProvidedPerDay += provider.Value.EnergyOutput;
            }
            foreach (var harvester in harvesters)
            {
                needEnergy += 0;
                plumbusOreMined += 0;
            }

            totalEnergiProvided += energyProvidedPerDay;
        }
        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {energyProvidedPerDay}");
        sb.AppendLine($"Plumbus Ore Mined: {plumbusOreMined}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var energyMode = arguments[0];
        switch (energyMode)
        {
            case "Full":
                currentModeEnergy = "Full";
                break;
            case "Half":
                currentModeEnergy = "Half";
                break;
            case "Energy":
                currentModeEnergy = "Energy";
                break;
        }
        
        return $"Successfully changed working mode to {energyMode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        var sb = new StringBuilder();

        if (harvesters.ContainsKey(id))
        {
            foreach (var harvest in harvesters)
            {
                if (harvest.Key == id)
                {
                    var name = harvest.Value.GetType().Name;
                    var index = name.IndexOf("Harvester");
                    name = name.Insert(index, " ");

                    sb.AppendLine($"{name} - {harvest.Key}");
                    sb.AppendLine($"Ore Output: {harvest.Value.OreOutput}");
                    sb.AppendLine($"Energy Requirement: {harvest.Value.EnergyRequirement}");

                }
            }
            return sb.ToString().Trim();
        }
        else if (providers.ContainsKey(id))
        {
            foreach (var provider in providers)
            {
                if (provider.Key == id)
                {
                    var name = provider.Value.GetType().Name;
                    var index = name.IndexOf("Provider");
                    name = name.Insert(index, " ");

                    sb.AppendLine($"{name} - {provider.Key}");
                    sb.AppendLine($"Energy Output: {provider.Value.EnergyOutput}");
                }
            }
            return sb.ToString().Trim();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalEnergiProvided}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedPlumbusOre}");

        return sb.ToString().Trim();
    }

    private Harvester GetHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);


        if (type == "Sonic")
        {
            var sonicFactor = int.Parse(arguments[4]);
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        else
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }
    }

    private Provider GetProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        if (type == "Solar")
        {
            return new SolarProvider(id, energyOutput);
        }
        else
        {
            return new PressureProvider(id, energyOutput);
        }
    }

    

}
