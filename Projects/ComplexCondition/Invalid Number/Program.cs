using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());

            if (!(numb >= 100 && numb <=200 || numb == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
