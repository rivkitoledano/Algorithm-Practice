using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class SingleNumberSol
    {   
       public int SingleNumber(int[] nums) {
        int xorRes = 0;
        for(int i = 0; i < nums.Length; i++){
            xorRes ^= nums[i];
        }
        return xorRes;
    }
  }
}
