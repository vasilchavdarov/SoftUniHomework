using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= number; i++)
            {
                var specialSum = 0;
                var dings = i;
                while (dings > 0)
                {
                    specialSum += dings % 10;
                    dings = dings / 10;
                }
                if (specialSum == 5 || specialSum == 7 || specialSum == 11)
                {
                    Console.WriteLine($"{i} -> True" );
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
