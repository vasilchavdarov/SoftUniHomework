using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonachi_Number
{
    class Program
    {
        public static long fib(int n)
        {
            if (n <= 1)
                return 1;

            return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(n));
        }
    }

}







