using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_1_To_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < input; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
               
            }
            Console.WriteLine(sum);
        }
    }
}
