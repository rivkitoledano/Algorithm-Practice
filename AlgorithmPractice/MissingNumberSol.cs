using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class MissingNumberSol
    {   
      public int MissingNumber(int[] nums) {
        int sum = 0, allSum = 0;
        for(int i = 0; i<=nums.Length; i++){
            allSum += i;
        }
        for(int i = 0; i<nums.Length; i++){
            sum += nums[i];
        }
        return allSum - sum;
    }
  }
}
