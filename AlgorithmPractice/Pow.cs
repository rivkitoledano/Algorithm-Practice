using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class Pow
    {

        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            long N = n; 
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            if (N % 2 == 0)
            {
                double half = MyPow(x, (int)(N / 2));
                return half * half;
            }
            else
            {
                double half = MyPow(x, (int)(N / 2));
                return half * half * x;
            }
        }


    }
}
