using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndRegex_Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();

            text.Reverse();

            Console.WriteLine(string.Join("",text));

            
        }
    }
}
