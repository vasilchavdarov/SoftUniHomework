using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello__Name_
{
    class Program
    {
        public static void Name(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Name(name);

        }
    }
}
