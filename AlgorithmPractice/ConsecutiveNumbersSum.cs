using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class ConsecutiveNumbersSum
    {
        public static int ConsecutiveNumbersSumRec(int n,int idx, bool canTake)
        {
            if (n - idx == 0)
                return 1;
            if (n - idx > 0)
                return ConsecutiveNumbersSumRec(n - idx, idx - 1, true) + ConsecutiveNumbersSumRec(n, idx - 1, false);
            return ConsecutiveNumbersSumRec(n, idx - 1, false);
        }
    }
}
