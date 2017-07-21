using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            var countbuyhrizantem = int.Parse(Console.ReadLine());
            var countbuyrouses = int.Parse(Console.ReadLine());
            var countbuytulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var dayYorN = Console.ReadLine();

            var totalflower = countbuytulips + countbuyrouses + countbuyhrizantem;

            var pricehrizantemforsummer = countbuyhrizantem * 2.00;
            var pricerousesforsummer = countbuyrouses * 4.10;
            var pricetulipssummer = countbuytulips * 2.50;
            var totalsumforsummer = pricehrizantemforsummer + pricerousesforsummer + pricetulipssummer;

            var winterpricehrizantem = countbuyhrizantem * 3.75;
            var winterpricerouses = countbuyrouses * 4.50;
            var winterpricetulips = countbuytulips * 4.15;
            var wintertotalsum = winterpricehrizantem + winterpricerouses + winterpricetulips;



            if (dayYorN == "Y")
            {
                totalsumforsummer += totalsumforsummer * 15 / 100;
                wintertotalsum += wintertotalsum * 15 / 100;

                if (season == "Spring")
                {
                    
                    if (countbuytulips > 7)
                    {
                        totalsumforsummer = totalsumforsummer * 0.95;
                    }
                    if (totalflower > 20)
                    {
                        totalsumforsummer = totalsumforsummer * 0.80;
                    }
                    Console.WriteLine("{0:f2}", totalsumforsummer + 2);
                }
                else if (season == "Summer")
                {
                    
                    if (totalflower > 20)
                    {
                        totalsumforsummer = totalsumforsummer * 0.80;
                    }
                    Console.WriteLine("{0:f2}", totalsumforsummer + 2);
                }
                else if (season == "Autumn")
                {
                    if (totalflower > 20)
                    {
                        wintertotalsum = wintertotalsum * 0.80;
                    }
                    Console.WriteLine("{0:f2}", wintertotalsum + 2);
                }
                else
                {
                    if (countbuyrouses >= 10)
                    {
                        wintertotalsum = wintertotalsum * 0.90;
                    }
                    if (totalflower > 20)
                    {
                        wintertotalsum = wintertotalsum * 0.80;
                    }
                    Console.WriteLine("{0:f2}", wintertotalsum + 2);
                }
                
                

            }
            else
            {
                if (season == "Spring")
                {

                    if (countbuytulips > 7)
                    {
                        totalsumforsummer = totalsumforsummer * 0.95;
                    }
                    if (totalflower > 20)
                    {
                        totalsumforsummer = totalsumforsummer * 0.80;
                    }
                    Console.WriteLine("{0:f2}", totalsumforsummer + 2);
                }
                else if (season == "Summer")
                {

                    if (totalflower > 20)
                    {
                        totalsumforsummer = totalsumforsummer * 0.80;
                    }
                    Console.WriteLine("{0:f2}", totalsumforsummer + 2);
                }
                else if (season == "Autumn")
                {
                    if (totalflower > 20)
                    {
                        wintertotalsum = wintertotalsum * 0.80;
                    }
                    Console.WriteLine("{0:f2}", wintertotalsum + 2);
                    

                }
                else
                {
                    if (countbuyrouses >= 10)
                    {
                        wintertotalsum = wintertotalsum * 0.90;
                        
                    }
                    if (totalflower > 20)
                    {
                        wintertotalsum = wintertotalsum * 0.80;
                        
                    }
                    Console.WriteLine("{0:f2}", wintertotalsum + 2);
                }

                

            }

        }
    }
}
