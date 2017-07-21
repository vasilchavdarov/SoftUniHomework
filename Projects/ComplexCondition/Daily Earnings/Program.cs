using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysinmonth = int.Parse(Console.ReadLine());
            var earnmoneyforday = Double.Parse(Console.ReadLine());
            var usdtobgn = Double.Parse(Console.ReadLine());

            var moneyformonth = daysinmonth * earnmoneyforday;
            var bonus = moneyformonth * 2.5;
            var moneyforyear = (moneyformonth * 12) + bonus;
            var tax = moneyforyear * 0.25;
            var moneywithtax = moneyforyear - tax;

            var moneyinbgn = moneywithtax * usdtobgn;
            var ivanmoneyforday = moneyinbgn / 365;

            ivanmoneyforday = Math.Round(ivanmoneyforday, 2);
            Console.WriteLine("Result: " + ivanmoneyforday);

        }
    }
}
