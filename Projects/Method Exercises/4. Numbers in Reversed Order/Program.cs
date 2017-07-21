using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            var reverst = ReverstNum(num);
            Console.WriteLine(reverst);
            
        }

        private static double ReverstNum(double num)
        {
            var reverst = num.ToString();

            var reversedString = string.Empty;

            for (int i = reverst.Length - 1; i >= 0; i--)
            {
                reversedString += reverst[i];
            }

            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
