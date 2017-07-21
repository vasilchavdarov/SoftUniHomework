using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Desert
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfCash = double.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var pricePerBanana = double.Parse(Console.ReadLine());
            var pricePerEgg = double.Parse(Console.ReadLine());
            var priceForBerriesKg = double.Parse(Console.ReadLine());

            var priceForSixPortions = (2 * pricePerBanana) + (4 * pricePerEgg) + (0.2 * priceForBerriesKg);
            var totalPrice = 0.0;
            

            if (numberOfGuests % 6 == 0)
            {
                var needPortions = numberOfGuests / 6;
                totalPrice = needPortions * priceForSixPortions;
                
            }
            else
            {
                var needPortions = (numberOfGuests / 6) + 1;
                totalPrice = needPortions * priceForSixPortions;
            }
            
            if (amountOfCash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice - amountOfCash:F2}lv more.");
            }
            

        }
    }
}
