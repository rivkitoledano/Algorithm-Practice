using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class SearchRange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = FindBound(nums, target, true);
            if (first == -1) return new int[] { -1, -1 };
            int last = FindBound(nums, target, false);
            return new int[] { first, last };
        }

        private int FindBound(int[] nums, int target, bool isFirst)
        {
            int start = 0, end = nums.Length - 1, ans = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    ans = mid;
                    if (isFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ans;
        }
    }
}
