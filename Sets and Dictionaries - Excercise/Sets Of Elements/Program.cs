using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var set = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                set.Add(number);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (set.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
            
        }
    }
}
