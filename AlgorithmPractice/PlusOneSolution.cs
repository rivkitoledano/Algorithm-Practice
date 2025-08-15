using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            int num = int.Parse(string.Join("", digits));
            num += 1;
            return num.ToString()
                   .Select(ch => ch - '0')
                   .ToArray();

        }
    }
}
