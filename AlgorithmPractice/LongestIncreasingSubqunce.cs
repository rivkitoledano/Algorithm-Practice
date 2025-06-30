using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LongestIncreasingSubqunce
    {
        public int LongIncreasingSub(int[] nums, int idx, int prev)
        {
            if (idx < 0)
                return 0;
            if (nums[idx] < prev)
                return Math.Max(LongIncreasingSub(nums, idx - 1, prev), 1 + LongIncreasingSub(nums, idx - 1, nums[idx]));
            else
                return LongIncreasingSub(nums, idx - 1, prev);
        }

        public int LongIncreasingSubRec(int[] nums)
        {
            int[] arr = new int[nums.Length];
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
            //if (idx < 0)
            //    return 0;
            //if (nums[idx] < prev)
            //    return Math.Max(LongIncreasingSub(nums, idx - 1, prev), 1 + LongIncreasingSub(nums, idx - 1, nums[idx]));
            //else
            //    return LongIncreasingSub(nums, idx - 1, prev);
        }
    }
}
