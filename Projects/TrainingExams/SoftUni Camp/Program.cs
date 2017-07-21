using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var grupstudents = int.Parse(Console.ReadLine());

            var car = 0.0;
            var microbus = 0.0;
            var smallbus = 0.0;
            var bus = 0.0;
            var train = 0.0;

            for (int i = 0; i < grupstudents; i++)
            {
                var students = int.Parse(Console.ReadLine());
                if (students <= 5)
                {
                    car += students;
                }
                else if (students >= 6 && students <= 12)
                {
                    microbus += students;
                }
                else if (students >= 13 && students <= 25)
                {
                    smallbus += students;

                }
                else if (students >= 26 && students <= 40)
                {
                    bus += students;
                }
                else
                {
                    train += students;
                }
            }
            var totalstudents = car + microbus + smallbus + bus + train;

            Console.WriteLine("{0:F2}%",car / totalstudents * 100);
            Console.WriteLine("{0:F2}%",microbus / totalstudents * 100);
            Console.WriteLine("{0:F2}%",smallbus / totalstudents * 100);
            Console.WriteLine("{0:F2}%",bus / totalstudents * 100);
            Console.WriteLine("{0:F2}%",train / totalstudents * 100);

        }
    }
}
