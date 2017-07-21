using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.English_Name_оf_The_Last_Digit
{
    class Program
    {
        public static string EnglishNameOfLastDigit(long number)
        {
            var lastDigit =Math.Abs( number % 10);

            switch (lastDigit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                default:
                    return "nine";
                    break;


            }
        }

        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(EnglishNameOfLastDigit(number));

        }
    }
}
