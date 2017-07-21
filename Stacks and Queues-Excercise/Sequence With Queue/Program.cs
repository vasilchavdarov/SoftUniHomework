using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            
            var queue = new Queue<double>();
            var printQueue = new Queue<double>();
            queue.Enqueue(n);
            printQueue.Enqueue(n);
            

            for (int i = 0; i < 17; i++)
            {
                var firstOperation = queue.Peek() + 1;
                printQueue.Enqueue(firstOperation);
                queue.Enqueue(firstOperation);
                var secondOperation = 2 * queue.Peek() + 1;
                printQueue.Enqueue(secondOperation);
                queue.Enqueue(secondOperation);
                var thirdOperation = queue.Peek() + 2;
                printQueue.Enqueue(thirdOperation);
                queue.Enqueue(thirdOperation);

                queue.Dequeue();
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{printQueue.Dequeue()} ");
            }
            Console.WriteLine();

        }
    }
}
