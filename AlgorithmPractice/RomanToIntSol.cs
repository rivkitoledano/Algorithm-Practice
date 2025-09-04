using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class RomanToIntSol
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romans = new Dictionary<char, int> {
            {'I', 1}, {'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000}
        };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int value = romans[s[i]];

                if (i + 1 < s.Length && romans[s[i + 1]] > value)
                {
                    total -= value;
                }
                else
                {
                    total += value;
                }
            }

            return total;
        }
    }
}
