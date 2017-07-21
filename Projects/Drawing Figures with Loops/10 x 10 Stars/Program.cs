using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var row = "+";
            var inrow = "|";

            for (int i = 1; i <= n - 2; i++)
            {
                row += " -";
            }
            row += " +";

            
            Console.WriteLine(row);

            for (int i = 1; i <= n - 2; i++)
            {
                inrow += " -";
            }
            inrow += " |";
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(inrow);
            }


            
            Console.WriteLine(row);

        }
    }
}
