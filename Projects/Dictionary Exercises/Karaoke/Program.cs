using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participents = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();

            var result = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();
            
            while (line != "dawn")
            {
                var performance = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();

                var participen = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participents.Contains(participen) && songs.Contains(song))
                {
                    if (!result.ContainsKey(participen))
                    {
                        result[participen] = new List<string>();
                    }

                    var awards = result[participen];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                         
                    }
                }

                line = Console.ReadLine();
            }

            if (result.Any())
            {
                foreach (var kvp in result.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
                {
                    var participent = kvp.Key;
                    var awards = kvp.Value;
                    Console.WriteLine($"{participent}: {awards.Count} awards");

                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
