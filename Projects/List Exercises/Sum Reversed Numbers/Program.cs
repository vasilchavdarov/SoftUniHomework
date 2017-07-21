using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');

            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                var reverstNumber = currentNumber.Reverse().ToList();

                var revestStringNumber = string.Join("",reverstNumber);
                var result = int.Parse(revestStringNumber);
                sum += result;
            }

            Console.WriteLine(sum);
        }
    }
}
