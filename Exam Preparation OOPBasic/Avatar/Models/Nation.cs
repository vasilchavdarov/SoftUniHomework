using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetNationPower()
    {
        var bendersTotalPower = this.benders.Sum(b => b.GetPower());
        var monumentsIncreasePower = this.monuments.Sum(m => m.GetAffinity());
        var totalIncreasePower = (bendersTotalPower / 100) * monumentsIncreasePower;

        return bendersTotalPower + totalIncreasePower;
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }
}
