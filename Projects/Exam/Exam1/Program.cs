using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firsttimemin = double.Parse(Console.ReadLine());
            var secdondtimemin = double.Parse(Console.ReadLine());
            var thirdhtimemin = double.Parse(Console.ReadLine());

            var firsttimehours = firsttimemin / 60;
            var secondtimehours = secdondtimemin / 60;
            var thirdtimehours = thirdhtimemin / 60;

            var firstroad = firsttimehours * speed;
            var secondspeed = speed * 1.10;
            var secondroad = secondspeed * secondtimehours;
            var thirdspeed = secondspeed * 0.95;
            var thirdroad = thirdspeed * thirdtimehours;

            var totalroad = firstroad + secondroad + thirdroad;

            Console.WriteLine("{0:F2}",totalroad);
            


        }
    }
}
