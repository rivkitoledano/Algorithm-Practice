using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class CountJumps
    {
        public int Jump(int[] nums)
        {
            int minSteps = 0;
            int lengthArray = nums.Length - 1;
            int maxArrived = 0;
            int currentEnd = 0;
            for (int i = 0; i < lengthArray; i++)
            {
                maxArrived = Math.Max(maxArrived, i + nums[i]);
                if (currentEnd == i)
                {
                    minSteps++;
                    currentEnd = maxArrived;
                }

            }
            return minSteps;
        }
    }
}
