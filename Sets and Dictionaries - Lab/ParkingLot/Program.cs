using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var set = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");

                if (inputParams[0] == "IN")
                {
                    set.Add(inputParams[1]);
                }
                else
                {
                    set.Remove(inputParams[1]);
                }


                input = Console.ReadLine();
            }

            if (set.Count != 0)
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
