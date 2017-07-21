using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var guestList = new SortedSet<string>();

            while (input != "PARTY")
            {
                guestList.Add(input);

                input = Console.ReadLine();
            }
            while (input != "END")
            {
                guestList.Remove(input);

                input = Console.ReadLine();
            }
            
            Console.WriteLine(guestList.Count);
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
