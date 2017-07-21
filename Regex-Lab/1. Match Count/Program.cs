using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var patten = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(patten);
            var matches = regex.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}
