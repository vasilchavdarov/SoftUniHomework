using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();
                var previous = numbers[0];
                var count = 1;

                for (int i = 1; i < numbers.Count; i++)
                {
                    var currentNumber = numbers[i];
                    if (currentNumber == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} -> {count}");
                        count = 1;
                    }
                    previous = currentNumber;
                }
                Console.WriteLine($"{previous} -> {count}");
            }
        }
    }
}
