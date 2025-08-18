using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class TwoSinglesNumber
    {
        public int[] SingleNumber(int[] nums) {
            int xorRes = 0;
            foreach (int num in nums) {
                xorRes ^= num;
            }
    
            int diffBit = xorRes & -xorRes;
    
            int a = 0, b = 0;
            foreach (int num in nums) {
                if ((num & diffBit) == 0) {
                    a ^= num;
                } else {
                    b ^= num;
                }
            }
    
            return new int[] { a, b };
        }
    }
}
