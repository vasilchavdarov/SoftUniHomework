using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_miner_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countLine = 1;
            var dictionary = new Dictionary<string, int>();
            var resourse = string.Empty;
            while (input != "stop")
            {
                
                if (countLine % 2 != 0)
                {
                    if (!dictionary.ContainsKey(input))
                    {
                        resourse = input;
                        dictionary.Add(resourse, 0);
                    }
                    else
                    {
                        resourse = input;
                    }
                    
                }
                else
                {
                    if (dictionary.ContainsKey(resourse))
                    {
                        var quanty = int.Parse(input);
                        dictionary[resourse] += quanty;
                    }
                    
                }
                countLine++;
                input = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
