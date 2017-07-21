using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_Lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            if (input.Length < 20)
            {
                var paded = input.PadRight(20, '*');
                Console.WriteLine($"{paded}");
            }
            else
            {
                var paded = input.Take(20).ToArray();
                Console.WriteLine(paded);
            }

        }
    }
}
