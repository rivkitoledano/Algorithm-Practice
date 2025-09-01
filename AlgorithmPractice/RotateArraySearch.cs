using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class RotateArraySearch
    {
        public int Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target) return mid;

                if (nums[start] <= nums[mid])
                {
                    if (nums[start] <= target && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
