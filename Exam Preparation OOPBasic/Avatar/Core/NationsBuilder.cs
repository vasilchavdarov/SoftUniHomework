using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NationsBuilder
{
    private Dictionary<string,Nation> nations;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air",new Nation() },
            { "Water",new Nation() },
            { "Fire",new Nation() },
            { "Earth",new Nation() }
        };
    }
        
    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];

        Bender currentBender = GetBender(benderArgs);
        this.nations[benderType].AddBender(currentBender);

    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];

        Monument currentMonument = GetMonument(monumentArgs);
        this.nations[monumentType].AddMonument(currentMonument);
    }
    
    public string GetStatus(string nationsType)
    {

        return "";
    }
    public void IssueWar(string nationsType)
    {
        //TODO: Add some logic here … 
    }
    public string GetWarsRecord()
    {
        return "";
        //TODO: Add some logic here … 
    }

    private Bender GetBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderSecondPower = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                return new AirBender(benderName, benderPower, benderSecondPower);
            case "Water":
                return new WaterBender(benderName, benderPower, benderSecondPower);
            case "Fire":
                return new FireBender(benderName, benderPower, benderSecondPower);
            case "Earth":
                return new EarthBender(benderName, benderPower, benderSecondPower);
            default:
                throw new ArgumentException("Bender type is wrong!");

        }
    }


    private Monument GetMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var monumentAffinity = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                return new AirMonument(monumentName, monumentAffinity);
            case "Water":
                return new WaterMonument(monumentName, monumentAffinity);
            case "Fire":
                return new FireMonument(monumentName, monumentAffinity);
            case "Earth":
                return new EarthMonument(monumentName, monumentAffinity);
            default:
                throw new ArgumentException("Monument type is wrong!");

        }
    }

}
