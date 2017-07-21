using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shor_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(", ",text));
        }
    }
}
