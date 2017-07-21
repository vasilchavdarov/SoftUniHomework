using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            string[] items = values.Split(' ');

            double[] nums = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                nums[i] = double.Parse(items[i]);
            }

            int[] rounderNumbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                rounderNumbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} -> {rounderNumbers[i]}");
            }
        }

        
    }
}
