using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        var letterone = (char)('a' + i1);
                        var lettertwo = (char)('a' + i2);
                        var letterthree = (char)('a' + i3);

                        Console.WriteLine("{0}{1}{2}",letterone , lettertwo, letterthree);
                    }
                }
            }
        }
    }
}
