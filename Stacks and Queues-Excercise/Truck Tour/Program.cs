using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startIndex = new Queue<int>();

            var petrolHave = 0;

            for (int i = 0; i < n; i++)
            {
                var petrolPump = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var petrolGive = petrolPump[0];
                var distance = petrolPump[1];
                
                petrolHave += petrolGive - distance;
                if (petrolHave < 0)
                {
                    petrolHave = 0;
                    while (startIndex.Count != 0) 
                    {
                        startIndex.Dequeue();
                    }
                    continue;
                }
                else
                {
                    startIndex.Enqueue(i);
                }
                 
            }
            Console.WriteLine(startIndex.Min());
        }
    }
}
