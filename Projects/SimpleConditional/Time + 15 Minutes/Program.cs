using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var sum = min + 15;
            var totalhour = hour + sum / 60;
            var totalmin = sum % 60;

            if (totalhour >= 24)
            {
                Console.WriteLine("0:{0:00}", totalmin);
            }
            else
            {
                Console.WriteLine("{0:0}:{1:00}", totalhour, totalmin);
            }
        }
    }
}
