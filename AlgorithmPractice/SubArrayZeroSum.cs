using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class SubArrayZeroSum
    {
        public static int SubArrayZero(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0; 
            }
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            int maxLength = 0, currentSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];
                
                if (currentSum == 0)
                {
                    maxLength = i + 1; 
                }
                if (keyValues.ContainsKey(currentSum))
                {
                    maxLength = Math.Max(maxLength, i - keyValues[currentSum]);
                }
                else
                {
                    keyValues[currentSum] = i;
                }
            }
            return maxLength;
        }
    }
}
