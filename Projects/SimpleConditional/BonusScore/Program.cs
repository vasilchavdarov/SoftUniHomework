using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Double.Parse(Console.ReadLine());
            double bonusscore = 0;
            if (num <= 100)
            {
                bonusscore += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusscore += num * 0.20;
            }
            else if (num > 1000)
            {
                bonusscore += num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusscore++;
            }
            else if (num % 10 == 5)
            {
                bonusscore += 2;
            }
            Console.WriteLine(bonusscore);
            Console.WriteLine(num + bonusscore);
            
        }
    }
}
