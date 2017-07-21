using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Double.Parse(Console.ReadLine());
            var y1 = Double.Parse(Console.ReadLine());
            var x2 = Double.Parse(Console.ReadLine());
            var y2 = Double.Parse(Console.ReadLine());
            var x = Double.Parse(Console.ReadLine());
            var y = Double.Parse(Console.ReadLine());

            if (x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
               
            }
            else if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
              
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
