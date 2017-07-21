using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Parse_Url
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            
            

            if (input.Length != 2 || input[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var firstIndex = input[1].IndexOf('/');
                var server = input[1].Substring(0, firstIndex);
                var resources = input[1].Substring(firstIndex + 1);

                Console.WriteLine($"Protocol = {input[0]}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
