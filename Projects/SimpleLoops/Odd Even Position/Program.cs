﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = 0;
            double OddMax = 0;
            double EvenSum = 0;
            double EvenMin = 0;
            double EvenMax = 0;
            var smallnumber = double.MaxValue;
            var maxnumber = double.MinValue;

            if (input > 1)
            {
                for (var i = 0; i < input;i ++)
                {
                    var number = double.Parse(Console.ReadLine());
                    if (i % 2 != 0)
                    {
                        EvenSum += number;
                        if (number < smallnumber)
                        {
                            EvenMin = number;
                        }
                        if (number > maxnumber)
                        {
                            EvenMax = number;
                        }

                    }
                    
                }
            }
            Console.WriteLine($"OddSum={OddSum}");
            Console.WriteLine($"OddMin={OddMin}");
            Console.WriteLine($"OddMax={OddMax}");
            Console.WriteLine($"EvenSum={EvenSum}");
            Console.WriteLine($"EvenMin={EvenMin}");
            Console.WriteLine($"EvenMax={EvenMax}");
            

        }
    }
}
