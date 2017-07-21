using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstnumb = int.Parse(numbers[0]);
            var secondnumb = double.Parse(numbers[1]);
            var thirdnumb = double.Parse(numbers[2]);

            var brinaryFirstNumbe = Convert.ToString(firstnumb, 2).PadLeft(10, '0');



            Console.WriteLine($"|{firstnumb,-10:X}|{brinaryFirstNumbe}|{secondnumb,10:F2}|{thirdnumb,-10:f3}|");
        }
    }
}
