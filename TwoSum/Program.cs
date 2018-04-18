using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Console.WriteLine("Using Loop");
            TwoSumLoop(nums, target);

            Console.WriteLine("Using Dictionary");
            TwoSumMap(nums, target);
            Console.ReadLine();
        }

        private static void TwoSumMap(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsValue(complement))
                {
                    Console.WriteLine($"[{dic[complement]},{i}]");
                    return;                }
                else
                {
                    dic.Add(i, nums[i]);
                }
            }
            Console.WriteLine($"No two numbers add to {target}");
        }

        private static void TwoSumLoop(int[] nums, int target)
        {
           for(int i = 0; i <= nums.Length-1; i++)
            {
                for(int j = i + 1; j < nums.Length ; j++)
                {
                    if (nums[i] + nums[j] == target)
                        Console.WriteLine($"======= [{nums[i]},{nums[j]}]==========="); 
                    else
                        Console.WriteLine($"[{nums[i]},{nums[j]}] = {nums[i]},{nums[j]}");
                }
            }
        }
    }
}
