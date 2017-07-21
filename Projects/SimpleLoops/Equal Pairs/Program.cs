using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = double.Parse(Console.ReadLine());
            var moneyforstudio = 0.0;
            var moneyforapartment = 0.0;
            


            if (month == "may" || month == "october")
            {
                var studiomoney = nights * 50;
                var apartmentmoney = nights * 65;

                if (nights > 7 && nights <= 14)
                {
                    var bonusmoney = studiomoney * 0.05;
                    moneyforstudio = studiomoney - bonusmoney;
                    moneyforapartment = apartmentmoney;
                }
                else if (nights > 14)
                {
                    var bonusmoney = studiomoney * 0.30;
                    moneyforstudio = studiomoney - bonusmoney;
                    var bonusforapartment = apartmentmoney * 0.10;
                    moneyforapartment = apartmentmoney - bonusforapartment;

                }
                else
                {
                    moneyforapartment = apartmentmoney;
                    moneyforstudio = studiomoney;
                }

            }
            else if (month == "june" || month == "september")
            {
                var studiomoney = nights * 75.20;
                var apartmentmoney = nights * 68.70;

                if (nights > 14)
                {
                    var bonusmoney = studiomoney * 0.20;
                    moneyforstudio = studiomoney - bonusmoney;
                    var bonusforapartment = apartmentmoney * 0.10;
                    moneyforapartment = apartmentmoney - bonusforapartment;
                }
                else
                {
                    moneyforapartment = apartmentmoney;
                    moneyforstudio = studiomoney;
                }
            }
            else if (month == "july" || month == "august")
            {
                var studiomoney = nights * 76;
                var apartmentmoney = nights * 77;

                if (nights > 14)
                {
                    var bonusforapartment = apartmentmoney * 0.10;
                    moneyforapartment = apartmentmoney - bonusforapartment;
                    moneyforstudio = studiomoney;
                }
                else
                {
                    moneyforapartment = apartmentmoney;
                    moneyforstudio = studiomoney;
                }
            }

            Console.WriteLine($"Apartment: {moneyforapartment:f2} lv.");
            Console.WriteLine($"Studio: {moneyforstudio:f2} lv.");
        }
    }
}
