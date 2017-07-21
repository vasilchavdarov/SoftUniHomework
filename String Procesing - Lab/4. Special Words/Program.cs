using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new[] { ' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?' };
            var specialWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < specialWords.Length; i++)
            {
                dictionary.Add(specialWords[i], 0);
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < specialWords.Length; j++)
                {
                    if (text[i] == specialWords[j])
                    {
                       
                        dictionary[text[i]]++;
                    
                    }
                }
                
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
