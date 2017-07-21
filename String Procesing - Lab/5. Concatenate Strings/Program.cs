using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(Console.ReadLine() + " ");
            }

            Console.WriteLine(sb);

        }
    }
}
