using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyheve = double.Parse(Console.ReadLine());
            var wightsweat = double.Parse(Console.ReadLine());
            var laughttsweat = double.Parse(Console.ReadLine());
            var sadiofrectangle = double.Parse(Console.ReadLine());
            var hightofrectangle = double.Parse(Console.ReadLine());
            var priceforplate = double.Parse(Console.ReadLine());
            var priceformaster = double.Parse(Console.ReadLine());

            var sweatarea = wightsweat * laughttsweat;
            var platearea = sadiofrectangle * hightofrectangle / 2;
            var needplate = Math.Ceiling (sweatarea / platearea) + 5;
            var totalmoney = (needplate * priceforplate) + priceformaster;

            if (totalmoney <= moneyheve)
            {
                Console.WriteLine("{0:f2} lv left.",moneyheve - totalmoney);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",totalmoney - moneyheve);
            }
            

        }
    }
}
