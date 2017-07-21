using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = (Console.ReadLine());
            var secondname = (Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}" , name , secondname);

        }
    }
}
