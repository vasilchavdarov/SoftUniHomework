using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var linedots = ((3 * n) - 2) / 2; 
            var inputline = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string ('.',linedots), new string (' ',inputline));
                inputline += 2;
                linedots--;
            }

            linedots = n / 2;
            inputline = n * 2;

            Console.WriteLine("{0}{1}{0}",new string ('.',linedots), new string ('*',inputline));

            inputline = (n * 2) - 2;

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string ('.',linedots), new string ('\\',inputline));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string ('.',linedots), new string ('*',inputline));
                inputline += 2;
                linedots--;
            }
        }
    }
}
