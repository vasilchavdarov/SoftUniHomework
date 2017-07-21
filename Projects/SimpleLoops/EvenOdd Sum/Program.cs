using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evensum = 0;
            var oddsum = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    evensum += number;
                }
                else
                {
                    oddsum += number;
                }
            }
            Console.WriteLine("even " + evensum);
            Console.WriteLine(oddsum);
            //if (evensum == oddsum)
            //{
            //    Console.WriteLine("Yes Sum = {0}",evensum);
            //}
            //else
            //{
            //    Console.WriteLine("No Diff = {0}",Math.Abs(evensum - oddsum));
            //}

        }   
        
    }
}
