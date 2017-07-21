using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var childrens = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(childrens);

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
