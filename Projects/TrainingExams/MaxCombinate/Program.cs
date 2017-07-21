using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinate
{
    class Program
    {
        static void Main(string[] args)
        {
            var startnumber = int.Parse(Console.ReadLine());
            var endnumber = int.Parse(Console.ReadLine());
            var maxcombination = int.Parse(Console.ReadLine());

            var stop = 0;

            for (int i = startnumber; i <= endnumber; i++)
            {
                for (int j = startnumber; j <= endnumber; j++)
                {
                    Console.Write("<{0}-{1}>",i , j);
                    stop++;

                    if (stop == maxcombination)
                    {
                        break;
                    }

                }
                if (stop == maxcombination)
                {
                    break;
                }
                
            }
            Console.WriteLine();
        }
    }
}
