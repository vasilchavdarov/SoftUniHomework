using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        public static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            var maxNumber = Math.Max(firstNumber, secondNumber);
            var lastMaxNumber = Math.Max(maxNumber, thirdNumber);
            return lastMaxNumber;



        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstNumber, secondNumber, thirdNumber));

        }
    }
}
