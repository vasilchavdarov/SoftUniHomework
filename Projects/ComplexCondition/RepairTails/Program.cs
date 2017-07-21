using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairTails
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Double.Parse(Console.ReadLine());
            var wtails = Double.Parse(Console.ReadLine());
            var ltails = Double.Parse(Console.ReadLine());
            var m = Double.Parse(Console.ReadLine());
            var o = Double.Parse(Console.ReadLine());

            var nkv = n * n;
            var tails = wtails * ltails;
            var bench = m * o;

            var totalnkv = nkv - bench;
            var totaltiles = totalnkv / tails;
            var time = totaltiles * 0.20;

            Console.WriteLine(totaltiles);
            Console.WriteLine(time);


        }
    }
}
