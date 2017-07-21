using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoli = 3.25;
            var ziombul = 4.0;
            var roses = 3.50;
            var cactus = 8.00;

            var magnolicount = int.Parse(Console.ReadLine());
            var ziombulcount = int.Parse(Console.ReadLine());
            var rosescount = int.Parse(Console.ReadLine());
            var cactuscount = int.Parse(Console.ReadLine());
            var giftprice = double.Parse(Console.ReadLine());

            var magnoliprice = magnolicount * magnoli;
            var ziombulprice = ziombulcount * ziombul;
            var rosesprice = rosescount * roses;
            var cactusprice = cactuscount * cactus;

            var pricefromflower = magnoliprice + ziombulprice + rosesprice + cactusprice;
            var tax = pricefromflower * 5 / 100;
            var totalprice = pricefromflower - tax;

            if (totalprice >= giftprice)
            {
                var othermoney = Math.Floor(totalprice - giftprice);
                Console.WriteLine("She is left with {0} leva.", othermoney);
                
            }
            else
            {
                var othermoney = Math.Ceiling(giftprice - totalprice);
                Console.WriteLine("She will have to borrow {0} leva.", othermoney);

            }

        }
    }
}
