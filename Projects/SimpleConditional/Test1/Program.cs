using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var inn = Console.ReadLine();
            var outt = Console.ReadLine();
            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;

            switch (inn)
            {
                case "BGN":
                    break;
                case "USD":
                    a = a * usd;
                    break;
                case "EUR":
                    a = a * eur;
                    break;
                case "GBP":
                    a = a * gbp;
                    break;
                default:
                    break;
            }

            switch (outt)
            {
                case "BGN":
                    a = a / bgn;
                    break;
                case "USd":
                    a = a / usd;
                    break;
                case "EUR":
                    a = a / eur;
                    break;
                case "GBP":
                    a = a / gbp;
                    break;
                default:
                    break;

            }
            a = Math.Round(a, 2);
            Console.WriteLine(a + " " + outt);
        }
    }
}