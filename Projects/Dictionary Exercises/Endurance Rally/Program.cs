using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var track = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver.First();

                for (int i = 0; i < track.Length; i++)
                {
                    var currentFuel = track[i];

                    if (checkpoints.Contains(i))
                    {
                        fuel += currentFuel;
                    }
                    else
                    {
                        fuel -= currentFuel;
                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    }
                    
                }
                if (!(fuel <= 0))
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
                
                

            }

        }
    }
}
