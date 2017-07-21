using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var random = new Random();

            var result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomWord = random.Next(0, words.Length);

                var tempWord = words[randomWord];
                words[i] = tempWord;
                words[randomWord] = currentWord;

            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
