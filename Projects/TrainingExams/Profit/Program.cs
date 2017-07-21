using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var numbcopy = number;

            var numb3 = number % 10;
            numbcopy = number / 10;
            var numb2 = numbcopy % 10;
            numbcopy = numbcopy / 10;
            var numb1 = numbcopy % 10;

            for (int i = 0; i < numb1 + numb2; i++)
            {
                for (int j = 0; j < numb1 + numb3; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= numb1;
                        Console.Write("{0} ",number);
                    }
                    else if (number % 3 == 0)
                    {
                        number -= numb2;
                        Console.Write("{0} ", number);
                    }
                    else
                    {
                        number += numb3;
                        Console.Write("{0} ", number);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
