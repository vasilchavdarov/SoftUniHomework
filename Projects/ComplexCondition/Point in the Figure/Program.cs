using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace point_in_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if ((x > 0 && x < 3 * h && y > 0 && y < 1 * h) || (x > 1 * h && x < 2 * h && y > 0 && y < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else if (((x >= 0 && x <= 3 * h && y == 0) || (x >= 0 && x <= 1 * h && y == 1 * h) || (x >= 2 * h && x <= 3 * h && y == 1 * h) || 
                (x <= 2 * h && x >= 1 * h && y == 4 * h)) || ((x == 0 && y <= 1 * h && y >= 0) || (x == 3 * h && y <= 1 * h && y >= 0) || 
                (x == 1 * h && y >= 1 * h && y <= 4 * h) || (x == 2 * h && y >= 1 * h && y <= 4 * h)))
            {
                Console.WriteLine("border");
            }
            else
                Console.WriteLine("outside");
        }
    }
}