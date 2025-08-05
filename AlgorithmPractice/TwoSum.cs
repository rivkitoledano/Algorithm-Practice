using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class TwoSum
    {
        public int[] TowSum(int[] nums,int target)
        {
            // [1,2,4,3] 5
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            for (int i = 0; i<nums.Length; i++)
            {
                if (keyValues.ContainsKey(target - nums[i]))
                {
                    return new int[] { keyValues[target - nums[i]], i };
                }
                if (!keyValues.ContainsKey(nums[i]))
                {
                    keyValues.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 }; 
        }
    }
}
