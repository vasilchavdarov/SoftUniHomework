using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = Double.Parse(Console.ReadLine());
            var BGN = Math.Round(USD * 1.79549, 2);
            Console.WriteLine(BGN);

            //1 USD = 1.79549 BGN       }
        }
    }
}
