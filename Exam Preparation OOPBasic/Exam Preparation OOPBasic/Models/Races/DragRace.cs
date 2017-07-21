using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DragRace : Race
{
    public DragRace(int lenght, string route, int prizePool) 
        : base(lenght, route, prizePool)
    {
    }

    public override int GetPerfomance(int id)
    {
        var car = this.Participants[id];

        return (car.HorsePower / car.Acceleration);
    }
}
