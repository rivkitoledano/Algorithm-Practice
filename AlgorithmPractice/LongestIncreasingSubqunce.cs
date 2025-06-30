using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LongestIncreasingSubqunce
    {
        public static int LongIncreasingSubRec(int[] nums, int idx, int prev)
        {
            if (idx < 0)
                return 0;
            if (nums[idx] < prev)
                return Math.Max(LongIncreasingSubRec(nums, idx - 1, prev), 1 + LongIncreasingSubRec(nums, idx - 1, nums[idx]));
            else
                return LongIncreasingSubRec(nums, idx - 1, prev);
        }

        public static int LongIncreasingSub(int[] nums)
        {
            int[] arr = new int[nums.Length];
            if (nums.Length == 0)
                return 0;
            arr[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                arr[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        arr[i] = Math.Max(arr[i], arr[j] + 1);
                    }
                }
            }
            return arr.Max();

        }
    }
}
