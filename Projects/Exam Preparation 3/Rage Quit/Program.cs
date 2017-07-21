using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var paten = @"(\D+)(\d+)";
            var regex = new Regex(paten);

            var inputline = Console.ReadLine().ToUpper();

            var matches = regex.Matches(inputline);
            
            var outputResult = new StringBuilder();

            foreach (Match match in matches)
            {
                var message = match.Groups[1].Value;
                var repeat = int.Parse(match.Groups[2].Value);

                

                for (int i = 0; i < repeat; i++)
                {
                    outputResult.Append(message);
                }
            }

            Console.WriteLine($"Unique symbols used: {outputResult.ToString().Distinct().Count()}");
            Console.WriteLine(outputResult);
        }
    }
}
