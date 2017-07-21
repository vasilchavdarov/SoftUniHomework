using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	1 биткойн = 1168 лева.
            //•	1 китайски юан = 0.15 долара.
            //•	1 долар = 1.76 лева.
            //•	1 евро = 1.95 лева

            var bitkoin = Double.Parse(Console.ReadLine());
            var una = Double.Parse(Console.ReadLine());
            var comision = Double.Parse(Console.ReadLine());

            var bitkointoleva = bitkoin * 1168;
            var unatousd = una * 0.15;
            var usdtoleva = unatousd * 1.76;
            var levatoeur = (bitkointoleva + usdtoleva) / 1.95;

            var comisionineur = (levatoeur * comision) / 100;
            var totaleur = levatoeur - comisionineur;

            Console.WriteLine(totaleur);

            
        }
    }
}
