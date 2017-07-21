using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());

            var widht = n * 2 + 3;
            var stars = 1;
            var dash = widht - 4;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string ('*',stars) , new string ('-', dash));
                stars++;
                dash -= 2;
            }
            stars = n / 2;
            dash = n;

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",new string ('*',stars), new string ('*',dash));
                stars++;
                dash -= 2;
            }

            stars = 1;
            dash = widht - 4;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string ('-',stars), new string ('*',dash));
                stars++;
                dash -= 2;
            }

        }
    }
}
