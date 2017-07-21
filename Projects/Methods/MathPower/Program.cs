using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        public static double ReiseToPower (double number, int power)
        {
            var numb = number;
            for (int i = 1; i < power; i++)
            {
                numb *= number;
            }
            return numb;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            var result = ReiseToPower(number, power);
            Console.WriteLine(result);
        }
    }
}
