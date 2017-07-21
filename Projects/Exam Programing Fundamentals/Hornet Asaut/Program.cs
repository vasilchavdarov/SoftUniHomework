using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Asaut
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornetspower = hornets.Sum();

            var aliveBeehives = new List<long>();

            for (int i = 0; i < beehives.Count; i++)
            {
                
                if (hornetspower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else if (hornetspower == 0)
                {
                    aliveBeehives.Add(beehives[i]);
                }
                else
                {
                    var alivebehev = beehives[i] - hornetspower;
                    aliveBeehives.Add(alivebehev);
                    hornets.RemoveAt(0);
                    hornetspower = hornets.Sum();
                    
                }

                
                
            }
            beehives.Remove(0);
            aliveBeehives.Remove(0);

            if (hornetspower != 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }

            
        }
    }
}
