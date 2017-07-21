using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourexam = int.Parse(Console.ReadLine());
            var minexam = int.Parse(Console.ReadLine());
            var hourarrive = int.Parse(Console.ReadLine());
            var minarrive = int.Parse(Console.ReadLine());

            var examTime = hourexam * 60 + minexam;
            var arriveTime = hourarrive * 60 + minarrive;
            var minutesDifference = (arriveTime - examTime);

            if (minutesDifference < -30)
            {
                var hours = Math.Abs(minutesDifference / 60);
                var min = Math.Abs(minutesDifference % 60);
                Console.WriteLine("Early");
                if (hours <= 0)
                {
                    Console.WriteLine(min + " minutes before the start");
                }
                else //(hours > 0) 
                {
                    Console.WriteLine($"{hours}:{min:00} " + " hours before the start");
                }
            }
            else if (minutesDifference <= 0)
            {
                var hours = Math.Abs(minutesDifference / 60);
                var min = Math.Abs(minutesDifference % 60);
                Console.WriteLine("On time");
                Console.WriteLine($"{min}" + " minutes before the start");
            }
            else
            {
                var hours = Math.Abs(minutesDifference / 60);
                var min = Math.Abs(minutesDifference % 60);
                Console.WriteLine("Late");
                if (hours <= 0)
                {
                    Console.WriteLine(min + " minutes after the start");
                }
                else //(hours > 0) 
                {
                    Console.WriteLine($"{hours}:{min:00} " + " hours after the start");
                }
            }




        }
    }
}
