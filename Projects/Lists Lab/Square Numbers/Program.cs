using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var squareNumbers = new List<double>();


            for (int i = 0; i < number.Count; i++)
            {
                var curentNumber = number[i];
                var square = Math.Sqrt(curentNumber);
                if (square == (int)square)
                {
                    squareNumbers.Add(curentNumber);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();

            Console.WriteLine(string.Join(" ",squareNumbers));
        }
    }
}
