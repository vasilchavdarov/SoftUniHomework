﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;

            }
            Console.WriteLine(sum);
        }
    }
}
