using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine();

            var count = 0;
            var index = 0;

            while (true)
            {
                var found = text.IndexOf(searchString, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }

                
            }
            Console.WriteLine(count);


        }
    }
}
