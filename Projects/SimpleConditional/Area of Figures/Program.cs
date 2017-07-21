using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var a = Double.Parse(Console.ReadLine());
                var area = a * a;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                var a = Double.Parse(Console.ReadLine());
                var b = Double.Parse(Console.ReadLine());
                var area = a * b;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                var r = Double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                var a = Double.Parse(Console.ReadLine());
                var h = Double.Parse(Console.ReadLine());
                var area = a * h / 2;
                area = Math.Round(area, 3);
                Console.WriteLine(area);
            }
        }
    }
}
