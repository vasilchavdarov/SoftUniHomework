using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Object_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy",CultureInfo.InstalledUICulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
