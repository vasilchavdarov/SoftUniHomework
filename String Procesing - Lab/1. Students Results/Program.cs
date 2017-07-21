using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Students_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name", "CAdv", "COOP", "AdvOOP", "Average"));
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var studentName = input[0];
                var firstResult = double.Parse(input[1]);
                var secondResult = double.Parse(input[2]);
                var thirdResult = double.Parse(input[3]);
                var average = (firstResult + secondResult + thirdResult) / 3;

                Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",studentName, firstResult, secondResult, thirdResult, average);
            }
        }
    }
}
