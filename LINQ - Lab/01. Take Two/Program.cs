using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Take_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().Where(n => n >= 10 && n <= 20).Take(2);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
