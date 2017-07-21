using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mm = 1000;
            var cm = 100;
            var mi = 0.000621371192;
            var inch = 39.3700787;
            var km = 0.001;
            var ft = 3.2808399;
            var yd = 1.0936133;

            var meter = Double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            if (input == "mm")
            {
                meter /= mm;

            }
            else if (input == "cm")
            {
                meter /= cm;
            } 
            else if (input == "mi")
            {
                meter /= mi;
            }
            else if (input == "in")
            {
                meter /= inch;
            }
            else if (input == "km")
            {
                meter /= km;
            }
            else if (input == "ft")
            {
                meter /= ft;
            }
            else if (input == "yd")
            {
                meter /= yd;
            }


            if (output == "mm")
            {
                meter *= mm;

            }
            else if (output == "cm")
            {
                meter *= cm;
            }
            else if (output == "mi")
            {
                meter *= mi;
            }
            else if (output == "in")
            {
                meter *= inch;
            }
            else if (output == "km")
            {
                meter *= km;
            }
            else if (output == "ft")
            {
                meter *= ft;
            }
            else if (output == "yd")
            {
                meter *= yd;
            }
            Console.WriteLine(meter + " " + output);


        }   

    }
}
