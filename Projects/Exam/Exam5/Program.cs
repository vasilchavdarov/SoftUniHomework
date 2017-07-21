using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wight = 4 * n + 1;
            var col = 2 * n;
            var dots = (wight - 3) / 2;
            

            Console.WriteLine("{0}/|\\{0}",new string ('.', dots));
            Console.WriteLine("{0}\\|/{0}",new string ('.', dots));

            for (int i = 0; i < col; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots - i),new string ('-',i));
            }


            Console.WriteLine("{0}",new string ('*',wight));
            for (int i = 0; i < wight / 2; i++)
            {
                Console.Write("{0}{1}",new string ('*', 1),new string ('.', 1));
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}",new string ('*',wight));
        }
    }
}
