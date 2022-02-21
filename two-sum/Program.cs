using System;

namespace two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target 的那 两个 整数，并返回它们的数组下标。
            //你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
            //你可以按任意顺序返回答案。
            int[] nums = { 8, 1, 2, 3, 4 };
            int target = 10;
            int[] twoSum = TwoSum(nums, target);
            for (int i = 0; i < twoSum.Length; i++)
            {
                Console.WriteLine(twoSum[i]);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] tgt = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            tgt[0] = i;
                            tgt[1] = j;
                            return tgt;
                        }
                    }
                }
            }
            return nums;
        }
    }
}
