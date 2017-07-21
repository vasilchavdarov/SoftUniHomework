using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split(' ');
        var truckInfo = Console.ReadLine().Split(' ');
        var busInfo = Console.ReadLine().Split(' ');

        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));


        var comandNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < comandNumber; i++)
        {
            try
            {
                var comandInfo = Console.ReadLine().Split(' ');
                var comand = comandInfo[0];
                var vehicle = comandInfo[1];
                var parameter = double.Parse(comandInfo[2]);

                if (vehicle == "Car")
                {
                    ExecuteAction(car, comand, parameter);
                }
                else if (vehicle == "Truck")
                {
                    ExecuteAction(truck, comand, parameter);
                }
                else if (vehicle == "Bus")
                {
                    ExecuteAction(bus, comand, parameter);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);

    }

    private static void ExecuteAction(Vehicle vehicle, string comand, double parameter)
    {
        switch (comand)
        {
            case "Drive":
                Console.WriteLine(vehicle.TryTravelDistance(parameter));
                break;
            case "Refuel":
                vehicle.Refuel(parameter);
                break;
            case "DriveEmpty":
                Console.WriteLine(vehicle.TryTravelDistance(parameter, false));
                break;
        }
    }
}
