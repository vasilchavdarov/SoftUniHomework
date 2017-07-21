using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var line = new string(' ', n - i);
                
                for (int j = 1; j <= i; j++)
                {
                    line += "* ";
                }
                Console.WriteLine(line);
            }

            for (int i = 0; i < n - 1; i++)
            {
                var row = new string(' ', i + 1) + "*";
                
                for (int j = n - (2 + i); j > 0; j--)
                {
                    row += " *";
                    

                }
                Console.WriteLine(row);
                //Console.WriteLine(row);

            }

        }
    }
}
