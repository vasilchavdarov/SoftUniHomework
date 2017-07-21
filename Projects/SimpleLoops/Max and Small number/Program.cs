using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_Small_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var small = int.MaxValue;
            var max = int.MinValue;

            for (int i = 0; i < input; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                if (numb < small)
                {
                    small = numb;
                    
                }
                if (numb > max)
                {
                    max = numb;
                }
            }
            Console.WriteLine(small);
            Console.WriteLine(max);
        }
    }
}
