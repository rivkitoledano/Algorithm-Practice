using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class CanJumpSolution
    {
        public bool CanJump(int[] nums)
        {
            int maxPossible = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxPossible)
                {
                    return false;
                }
                maxPossible = Math.Max(maxPossible, nums[i] + i);
            }
            return true;
        }
    }

}
