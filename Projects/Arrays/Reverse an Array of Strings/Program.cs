using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {

        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                SwapElements(nums, i, nums.Length - i - 1);
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        public static void SwapElements(string[] nums, int i, int j)
        {
            var oldElemet = nums[i];
            nums[i] = nums[j];
            nums[j] = oldElemet;

        }
    }
}
