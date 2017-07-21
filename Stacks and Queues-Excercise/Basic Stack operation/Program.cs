using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var n = int.Parse(firstLine[0]);
            var s = int.Parse(firstLine[1]);
            var x = int.Parse(firstLine[2]);
            var elements = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            var stack = new Stack<int>();
            
            for (int i = 0; i < n; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            
            if (stack.Count() == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
            
        }
    }
}
