using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class HappyNumber
    {
        public int SumSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }

        public bool IsHappy(int n)
        {
            int slow = n;
            int fast = n;

            do
            {
                slow = SumSquares(slow);           
                fast = SumSquares(SumSquares(fast));
            } while (slow != fast);

            return slow == 1;
        }
    }
}
