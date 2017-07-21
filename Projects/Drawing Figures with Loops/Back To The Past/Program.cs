using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var momey = double.Parse(Console.ReadLine());
            var yeartoleave = int.Parse(Console.ReadLine());
            var evenspendmoney = 0.0;
            var oddspendmoney = 0.0;
            var manyears = 18;
            var allmoney = 0.0;
            var manyearmoney = 0.0;

            for (int i = 1800; i <= yeartoleave; i++)
            {
                
                if (i % 2 == 0)
                {
                    evenspendmoney += 12000;
                }
                else
                {
                    
                    oddspendmoney = oddspendmoney + 12000 + (manyears * 50) ;
                    
                }
                manyears++;


            }
            
            allmoney = evenspendmoney + oddspendmoney;
            if (momey >= allmoney)
            {
                var needmoney = momey - allmoney;
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",needmoney);
            }
            else
            {
                var needmoney = Math.Abs(momey - allmoney);
                Console.WriteLine("He will need {0:f2} dollars to survive.",needmoney);
                
            }
            
            
        }
    }
}
