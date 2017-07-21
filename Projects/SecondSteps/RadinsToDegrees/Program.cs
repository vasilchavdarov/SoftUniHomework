using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadinsToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // degrees = radians*180/Math.PI;
            var r = Double.Parse(Console.ReadLine());
            var g = Math.Round(r * 180 / Math.PI);
            Console.WriteLine(g);
                            
        }
    }
}
