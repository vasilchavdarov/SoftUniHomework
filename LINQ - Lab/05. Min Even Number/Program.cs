﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                var numbers = Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).Min();
                Console.WriteLine($"{numbers:f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
