using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n + 1; i++)
            {
                var line = new string(' ', n - i) + new string('*',i) + " | " + new string('*', i) + new string(' ', n - i);
                Console.WriteLine(line);
            }
        }
    }
}
