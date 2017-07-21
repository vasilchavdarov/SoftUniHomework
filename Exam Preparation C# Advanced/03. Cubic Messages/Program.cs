using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var patten = @"(^\d+)([a-zA-Z]+)([^a-zA-Z]*$)";

            string line;
            while ((line = Console.ReadLine()) != "Over!")
            {
                var mesageLenght = int.Parse(Console.ReadLine());

                var match = Regex.Match(line, patten);
                if (match.Success)
                {
                    var numbers = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var endingNumbers = string.Empty;

                    if (match.Groups[3].Value != "")
                    {
                        endingNumbers = match.Groups[3].Value;
                    }

                    if (message.Length != mesageLenght)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(numbers + endingNumbers, @"\D*",string.Empty);

                    var sb = new StringBuilder();
                    foreach (var item in indexes)
                    {
                        var index = int.Parse(item.ToString());
                        if (index >= 0 && index < mesageLenght)
                        {
                            sb.Append(message[index]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }

                    Console.WriteLine($"{message} == {sb}");
                }
                
            }
        }
    }
}
