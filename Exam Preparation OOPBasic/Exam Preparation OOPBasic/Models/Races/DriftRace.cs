using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DriftRace : Race
{
    private int susspesionPerfomance;
    
    public DriftRace(int lenght, string route, int prizePool) 
        : base(lenght, route, prizePool)
    {
    }

    public int SusspecionPerfomance
    {
        get { return this.susspesionPerfomance; }
        set { this.susspesionPerfomance = value; }
    }

    public override int GetPerfomance(int id)
    {
        var car = this.Participants[id];

        return (car.Suspension + car.Durability);
    }
}
