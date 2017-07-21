using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            var starcount = char.Parse(Console.ReadLine());
            var endcount = char.Parse(Console.ReadLine());
            var withoutchar = char.Parse(Console.ReadLine());

            var counter = 0;
            
            
            for (var i = starcount; i <= endcount; i++)
            {
                for (var j = starcount; j <= endcount; j++)
                {
                    for (var k = starcount; k <= endcount; k++)
                    {
                        if (!(i == withoutchar || j == withoutchar || k == withoutchar))
                        {
                            counter++;
                            Console.Write($"{i}{j}{k} ");
                        }

                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
