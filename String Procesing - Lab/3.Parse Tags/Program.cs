using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            var startIndex = input.IndexOf(openTag);
            while (startIndex != -1)
            {
                var endIndex = input.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }

                var toBeRepleced = input.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var repleced = toBeRepleced.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();

                input = input.Replace(toBeRepleced, repleced);

                startIndex = input.IndexOf(openTag);
            }

            Console.WriteLine(input);
        }
    }
}
