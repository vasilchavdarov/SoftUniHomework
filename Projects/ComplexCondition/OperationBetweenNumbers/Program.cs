using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                if ((n1 + n2) % 2 == 0)
                {
                    var evenorodd = "even";
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2} - {evenorodd}");
                }
                else
                {
                    var evenorodd = "odd";
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2} - {evenorodd}");
                }
            }
            else if (operation == "-")
            {
                if ((n1 - n2) % 2 == 0)
                {
                    var evenorodd = "even";
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - {evenorodd}");
                }
                else
                {
                    var evenorodd = "odd";
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - {evenorodd}");
                }
            }
            else if (operation == "*")
            {
                if ((n1 * n2) % 2 == 0)
                {
                    var evenorodd = "even";
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - {evenorodd}");
                }
                else
                {
                    var evenorodd = "odd";
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - {evenorodd}");
                }
            }
            else if (operation == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2:f2}");
                }
            }
            else
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                }
            }
        }
    }
}
