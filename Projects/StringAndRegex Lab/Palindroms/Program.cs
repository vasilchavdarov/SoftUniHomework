using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] split = { ' ', ',', '.', '?', '!' };
            string[] array = Console.ReadLine().ToLower().Split(split,StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();
 
            foreach (string value in array)
            {
                if (IsPalindrome(value))
                {
                    list.Add(value);
                }
            }

            list.Sort();
            Console.WriteLine(string.Join(", ",list));
        }
        static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
 
    }
}