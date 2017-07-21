using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverst_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Trim().Split(' ');
            var stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var numb = int.Parse(numbers[i]);
                stack.Push(numb);
            }

            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
