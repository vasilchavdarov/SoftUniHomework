using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double person = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            var courses = Math.Ceiling (person / capacity);

            Console.WriteLine(courses);

        }
    }
}
