using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            s = new string(s.Where(char.IsLetterOrDigit).ToArray());
            s = s.ToLower();
            string reversed = s;
            char[] chars = reversed.ToCharArray();
            Array.Reverse(chars);
            reversed = new string(chars);
            return s == reversed;

        }
    }
}
