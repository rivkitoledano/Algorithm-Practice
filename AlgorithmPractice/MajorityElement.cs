using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class MajorityElement
    {
        public static int MajorityElementSolution(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
                else if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }

            }
            return candidate;
        }
    }
}
