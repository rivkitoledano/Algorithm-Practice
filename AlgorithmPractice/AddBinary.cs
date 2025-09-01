using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class AddBinary
    {
        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            var sb = new System.Text.StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i] - '0';
                if (j >= 0) sum += b[j] - '0';

                sb.Insert(0, (sum % 2).ToString());
                carry = sum / 2;
                i--;
                j--;
            }

            return sb.ToString();
        }
    }
}
