using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var topstudents = 0.0;
            var beetwen4students = 0.0;
            var beetwen3students = 0.0;
            var failstudents = 0.0;
            var average = 0.0;




            for (int i = 1; i <= students; i++)
            {
                var evalution = double.Parse(Console.ReadLine());

                average += evalution;
                if (evalution >= 5)
                {
                    topstudents++;
                }
                else if (evalution >= 4 && evalution < 5)
                {
                    beetwen4students++;
                }
                else if (evalution >= 3 && evalution < 4)
                {
                    beetwen3students++;
                }
                else
                {
                    failstudents++;
                }

            }
            var p1 = topstudents * 100 / students;
            var p2 = beetwen4students * 100 / students;
            var p3 = beetwen3students * 100 / students;
            var p4 = failstudents * 100 / students;

            Console.WriteLine("Top students: {0:f2}%",p1);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",p2);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",p3);
            Console.WriteLine("Fail: {0:f2}%",p4);
            Console.WriteLine("Average: {0:f2}",average / students);
        }
    }
}
