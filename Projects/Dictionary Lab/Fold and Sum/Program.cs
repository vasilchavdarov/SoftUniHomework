using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var firstRowLeft = numbers.Take(k).Reverse().ToArray();
            var firstRowRight = numbers.Reverse().Take(k).ToArray();

            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            var secondRow = numbers.Skip(k).Take(k * 2).ToArray();

            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
