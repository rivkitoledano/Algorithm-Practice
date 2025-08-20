
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class StringToInteger
    {
        public int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            s = s.Trim();
            if (s.Length == 0) return 0;

            int sign = 1;
            int index = 0;

            if (s[0] == '-' || s[0] == '+')
            {
                sign = (s[0] == '-') ? -1 : 1;
                index++;
            }

            int number = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {
                int digit = s[index] - '0';

                if (number > (int.MaxValue - digit) / 10)
                    return (sign == 1) ? int.MaxValue : int.MinValue;

                number = number * 10 + digit;
                index++;
            }

            return number * sign;
        }
    }
}
