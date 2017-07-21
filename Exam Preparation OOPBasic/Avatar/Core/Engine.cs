using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private NationsBuilder nationBuilder;
    private bool isRunning;

    public Engine()
    {
        this.nationBuilder = new NationsBuilder();
        this.isRunning = true;
    }

    internal void Run()
    {
        while (this.isRunning)
        {
            var inputComant = Console.ReadLine();
            List<string> commandArgs = inputComant.Split(' ').ToList();
            ComandsExecute(commandArgs);
        }
    }

    private void ComandsExecute(List<string> commandArgs)
    {
        var command = commandArgs[0];
        commandArgs.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationBuilder.AssignBender(commandArgs);
                break;
            case "Monument":
                this.nationBuilder.AssignMonument(commandArgs);
                break;
            case "Status":
                this.nationBuilder.GetStatus(commandArgs[0]);
                break;
            case "War":
                break;
            case "Quit":
                isRunning = false;
                break;
        }
    }
}
