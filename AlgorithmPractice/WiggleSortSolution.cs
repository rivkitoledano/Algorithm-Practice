using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class WiggleSortSolution
    {
        public void WiggleSort(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int[] res = new int[n];

            int left = (n - 1) / 2;
            int right = n - 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    res[i] = nums[left--];
                }
                else
                {
                    res[i] = nums[right--];
                }
            }
            for (int i = 0; i < n; i++) nums[i] = res[i];
        }
    }
}
