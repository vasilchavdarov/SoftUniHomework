using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cubic_s_Rube
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensionSize = int.Parse(Console.ReadLine());
            var sum = 0l;
            var countcels = Math.Pow(dimensionSize, 3);

            string line;
            while ((line = Console.ReadLine()) != "Analyze")
            {
                var tokens = line.Split(' ').Select(int.Parse).ToArray();
                if (tokens.Take(3).Any(n => n < 0 || n >= dimensionSize))
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sum += tokens[3];
                    countcels--;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(countcels);
        }
    }
}
