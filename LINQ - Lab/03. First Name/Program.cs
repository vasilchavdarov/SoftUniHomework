using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var letters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(w => w);

            foreach (var letter in letters)
            {
                var result = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    break;
                }
                else
                {
                    Console.WriteLine("No match");
                    break;
                }
            }
            
        }
    }
}
