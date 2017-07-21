using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageRegex = new Regex(@"(\d+)\s<->\s([A-Za-z\d]+)$");
            var broadcastRegex = new Regex(@"(\D+)\s?<->\s([A-Za-z\d]+)$");

            var messagedict = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "Hornet is Green")
            {
                
                //Messages
                var matches = messageRegex.Match(line);
                var code = matches.Groups[1].Value;
                var message = matches.Groups[2].Value;
                var reversedCode = string.Empty;

                for (int i = code.Length - 1; i >= 0; i--)
                {
                    reversedCode += code[i];
                }
                if (!messagedict.ContainsKey(reversedCode))
                {
                    
                }

                //Broardcast
                var matchbroardcast = broadcastRegex.Match(line);
                var frequanci = matchbroardcast.Groups[2];
                var massagebroad = matchbroardcast.Groups[1];



                
                line = Console.ReadLine();

            }
            Console.WriteLine("Messages:");
            foreach (var item in messagedict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}
