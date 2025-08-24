using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LongestPalindromeSubtring
    {
        public string IsPali(string s, int idxStart, int idxEnd)
        {
            int left = idxStart, right = idxEnd;
            while (left <= right)
            {
                if (s[left] != s[right])
                    return "";
                left++;
                right--;
            }
            return s.Substring(idxStart, idxEnd - idxStart + 1);
        }

        public string LongestPalindromeRec(string s, int idxStart, int idxEnd)
        {
            if (s == null) return null;
            if (idxStart > idxEnd) return "";
            if (idxStart == idxEnd) return s[idxStart].ToString();

            string res = IsPali(s, idxStart, idxEnd);
            if (res != "") return res;

            string left = LongestPalindromeRec(s, idxStart + 1, idxEnd);
            string right = LongestPalindromeRec(s, idxStart, idxEnd - 1);

            return left.Length > right.Length ? left : right;
        }

        public string LongestPalindrome(string s)
        {
            return LongestPalindromeRec(s, 0, s.Length - 1);
        }
    }
}
