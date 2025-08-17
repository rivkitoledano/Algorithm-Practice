using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class PalindromNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string stringNum = x.ToString();
            int start = 0, end = stringNum.Length - 1;
            while (start < end)
            {
                if (stringNum[start] != stringNum[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
