using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Second_Nature
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var secondLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var stack = new Stack<int>(secondLine);
            var queue = new Queue<int>(firstLine);
            var secondNature = new List<int>();

            while (true)
            {
                if (stack.Count != 0 && queue.Count != 0)
                {
                    var stackInt = stack.Pop();
                    var queueInt = queue.Dequeue();
                    var result = stackInt - queueInt;
                    if (result > 0)
                    {
                        
                        if (stack.Count != 0)
                        {
                            var numberToPush = stack.Pop() + result;
                            stack.Push(numberToPush);
                        }
                        else
                        {
                            stack.Push(result);
                        }
                    }
                    else if (result < 0)
                    {
                        result = Math.Abs(result);
                        var items = queue.ToArray();
                        queue.Clear();
                        queue.Enqueue(result);
                        foreach (var item in items)
                        {
                            queue.Enqueue(item);
                        }
                        
                    }
                    else
                    {
                        secondNature.Add(queueInt);
                    }
                }
                else
                {
                    break;
                }
            }
            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            while (queue.Count != 0 )
            {
                Console.Write($"{queue.Dequeue()} ");
            }
            Console.WriteLine();
            if (secondNature.Count != 0)
            {
                foreach (var flower in secondNature)
                {
                    Console.Write($"{flower} ");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
