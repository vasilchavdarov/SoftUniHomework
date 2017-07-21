using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Exercises
{
    public class BombNumbers
    {
        public static void Main()
        {
            
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var bomb = bombAndPower[0];
            var power = bombAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomb == numbers[i])
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, numbers.Count - 1);

                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    //i = 0;

                }
            }
            Console.WriteLine(numbers.Sum());
            
        }
    }
}
