using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (text != "END")
            {
                var regex = new Regex("^((([0][0-9]|[1][0-1]):[0-5][0-9]:[0-5][0-9] [AP]M)|12:00:00 [PA]M)$");
                var match = regex.Match(text);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                text = Console.ReadLine();
            }

        }
    }
}
