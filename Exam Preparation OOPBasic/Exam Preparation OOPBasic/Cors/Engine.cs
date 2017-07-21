using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    internal void Run()
    {
        string command;

        while ((command = Console.ReadLine()) != "Cops Are Here")
        {
            var comdArg = command.Split(' ');
            ExecuteCommand(comdArg);
        }
    }

    private void ExecuteCommand(string[] comdArg)
    {
        switch (comdArg[0])
        {
            case "register":
                int id = int.Parse(comdArg[1]);
                string type = comdArg[2];
                string brand = comdArg[3];
                string model = comdArg[4];
                int yearOfProduction = int.Parse(comdArg[5]);
                int horsepower = int.Parse(comdArg[6]); ;
                int acceleration = int.Parse(comdArg[7]); ;
                int suspension = int.Parse(comdArg[8]); ;
                int durability = int.Parse(comdArg[9]); ;
                manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "check":
                Console.WriteLine(manager.Check(int.Parse(comdArg[1])));
                break;
            case "open":
                manager.Open(int.Parse(comdArg[1]), comdArg[2], int.Parse(comdArg[3]), comdArg[4], int.Parse(comdArg[5]));
                break;
            case "participate":
                var carId = int.Parse(comdArg[1]);
                var raceId = int.Parse(comdArg[2]);
                manager.Participate(carId,raceId);
                break;
            case "start":
                raceId = int.Parse(comdArg[1]);
                Console.WriteLine(manager.Start(raceId));
                break;
            case "park":
                id = int.Parse(comdArg[1]);
                manager.Park(id);
                break;
            case "unpark":
                id = int.Parse(comdArg[1]);
                manager.Unpark(id);
                break;
            case "tune":
                var tuneIndex = int.Parse(comdArg[1]);
                var addOn = comdArg[2];
                manager.Tune(tuneIndex, addOn);
                break;
        }
    }
}
