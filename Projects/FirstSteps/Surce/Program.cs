using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surce
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = '*';
            Console.WriteLine("  " + o + o + o + "   " + o + o + o);
            Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
            Console.WriteLine(o + "     " + o + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(o + "     " + " " + "     " + o);
            Console.WriteLine(" " + o + "    " + "     " + o);
            Console.WriteLine("  " + o + "   " + "    " + o);
            Console.WriteLine("   " + o + "  " + "   " + o);
            Console.WriteLine("    " + o + "  " + " " + o);
            Console.WriteLine("     " + o + " " + o);
            Console.WriteLine("      " + o);
        }
    }
}
