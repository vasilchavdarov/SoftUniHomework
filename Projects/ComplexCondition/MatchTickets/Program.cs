using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var kategoria = Console.ReadLine().ToUpper();
            var grup = int.Parse(Console.ReadLine());

            if (grup >= 1 && grup <= 4)
            {
                var transport = budget * 0.75;
                var totalbudget = budget - transport;
                if (kategoria == "VIP")
                {
                    var tickets = grup * 499.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }

                }
                else
                {
                    var tickets = grup * 249.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }
                }
            }
            else if (grup >= 5 && grup <= 9)
            {
                var transport = budget * 0.60;
                var totalbudget = budget - transport;
                if (kategoria == "VIP")
                {
                    var tickets = grup * 499.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }

                }
                else
                {
                    var tickets = grup * 249.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }
                }
            }
            else if (grup >= 10 && grup <= 24)
            {
                var transport = budget * 0.50;
                var totalbudget = budget - transport;
                if (kategoria == "VIP")
                {
                    var tickets = grup * 499.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }

                }
                else
                {
                    var tickets = grup * 249.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }
                }
            }
            else if (grup >= 25 && grup <= 49)
            {
                var transport = budget * 0.40;
                var totalbudget = budget - transport;
                if (kategoria == "VIP")
                {
                    var tickets = grup * 499.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }

                }
                else
                {
                    var tickets = grup * 249.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }
                }
            }
            else
            {
                var transport = budget * 0.25;
                var totalbudget = budget - transport;
                if (kategoria == "VIP")
                {
                    var tickets = grup * 499.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }

                }
                else
                {
                    var tickets = grup * 249.99;
                    var remainingbudget = totalbudget - tickets;
                    if (remainingbudget >= 0)
                    {
                        Console.WriteLine($"Yes! You have {remainingbudget:F2} leva left.");
                    }
                    else
                    {
                        remainingbudget = Math.Abs(remainingbudget);
                        Console.WriteLine($"Not enough money! You need {remainingbudget:F2} leva.");
                    }
                }
            }
            
        }
    }
}
