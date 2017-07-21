using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, string>();
            var printDictionary = new Dictionary<string, string>();
            while (input != "search")
            {
                var splitInput = input.Split('-');
                string name = splitInput[0];
                var phone = splitInput[1];
                dictionary.Add(name,phone);

                input = Console.ReadLine();
            }

            while (true)
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                if (dictionary.ContainsKey(input))
                {
                    foreach (var item in dictionary)
                    {
                        if (item.Key == input)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }


        }
    }
}
