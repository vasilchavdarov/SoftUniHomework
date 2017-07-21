using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var needmoney = double.Parse(Console.ReadLine());
            var moneyfortoy = int.Parse(Console.ReadLine());

            var saving = 0;
            var moneyfromtoy = 0;
            var bonus = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    saving += bonus;
                    saving -= 1;
                    bonus += 10;

                }
                else
                {
                    moneyfromtoy += moneyfortoy;
                }
            }
            var allmoney = saving + moneyfromtoy;
            if (allmoney >= needmoney)
            {
                Console.WriteLine("Yes! {0:F2}", allmoney - needmoney);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", needmoney - allmoney);
            }
        }
    }
}
