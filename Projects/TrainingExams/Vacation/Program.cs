using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var teenegers = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var transportpricepeople = 0.0;
            var transportpriceteenegers = 0.0;
            var totaltransport = 0.0;

            if (transport == "train")
            {
                if (people + teenegers < 50)
                {
                    transportpricepeople = people * 24.99;
                    transportpriceteenegers = teenegers * 14.99;
                    totaltransport = (transportpricepeople + transportpriceteenegers) * 2;
                    
                }
                else
                {
                    var trainticketforpeople = 24.99 / 2;
                    var trainticketforteenegers = 14.99 / 2;

                    transportpricepeople = people * trainticketforpeople;
                    transportpriceteenegers = teenegers * trainticketforteenegers;
                    totaltransport = (transportpricepeople + transportpriceteenegers) * 2;
                }
            }
            else if (transport == "bus")
            {
                transportpricepeople = people * 32.50;
                transportpriceteenegers = teenegers * 28.50;
                totaltransport = (transportpricepeople + transportpriceteenegers) * 2;
            }
            else if (transport == "boat")
            {
                transportpricepeople = people * 42.99;
                transportpriceteenegers = teenegers * 39.99;
                totaltransport = (transportpricepeople + transportpriceteenegers) * 2;
            }
            else
            {
                transportpricepeople = people * 70.00;
                transportpriceteenegers = teenegers * 50.00;
                totaltransport = (transportpricepeople + transportpriceteenegers) * 2;
            }

            var hotelprice = nights * 82.99;
            var tax = (totaltransport + hotelprice) * 0.10;
            var allmoney = totaltransport + hotelprice + tax;

            Console.WriteLine("{0:f2}",allmoney);


        }
    }
}
