using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private DraftManager manager;
    private bool isRunning;

    public Engine()
    {
        this.manager = new DraftManager();
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
            case "RegisterHarvester":
                Console.WriteLine(manager.RegisterHarvester(commandArgs));
                break;
            case "RegisterProvider":
                Console.WriteLine(manager.RegisterProvider(commandArgs));
                break;
            case "Day":
                Console.WriteLine(manager.Day());
                break;
            case "Mode":
                Console.WriteLine(manager.Mode(commandArgs));
                break;
            case "Check":
                Console.WriteLine(manager.Check(commandArgs));
                break;
            case "Shutdown":
                Console.WriteLine(manager.ShutDown());
                isRunning = false;
                break;
        }
    }
}
