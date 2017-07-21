using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cubic_Assault
{
    class Program
    {
        public static int OneMilion = 1000000;
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, long>>();

            while (line != "Count em all")
            {
                var tokens = line.Trim().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var region = tokens[0];
                var typeMeteor = tokens[1];
                var countMeteor = int.Parse(tokens[2]);

                if (!dictionary.ContainsKey(region))
                {
                    dictionary[region] = new Dictionary<string, long>()
                    {
                        {"Green",0 },
                        {"Red",0 },
                        {"Black",0 }
                    };
                }

                dictionary[region][typeMeteor] += countMeteor;

                var nextTypeCount = dictionary[region]["Green"] / OneMilion;
                if (nextTypeCount > 0)
                {
                    dictionary[region]["Red"] += nextTypeCount;
                    dictionary[region]["Green"] %= OneMilion;
                }

                nextTypeCount = dictionary[region]["Red"] / OneMilion;
                if (nextTypeCount > 0)
                {
                    dictionary[region]["Black"] += nextTypeCount;
                    dictionary[region]["Red"] %= OneMilion;
                }

                line = Console.ReadLine();
            }

            var orderedRegion = dictionary.OrderByDescending(r => r.Value["Black"]).ThenBy(r => r.Key.Length).ThenBy(r => r.Key).ToDictionary(r => r.Key,r => r.Value);

            foreach (var region in orderedRegion)
            {
                Console.WriteLine(region.Key);
                foreach (var item in region.Value.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"-> {item.Key} : {item.Value}");
                }
            }

        }
    }
}
