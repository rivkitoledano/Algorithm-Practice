
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class ClimbStairs
    {
        public int ClimbStairs(int n) {
            if (n == 0){
              return 1;
            }
            if(n < 0 ){
              return 0;
            }
            return ClimbStairs(n-1)+ ClimbStairs(n-2);
        }
        public int ClimbStairsDinami(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
    
            int[] array = new int[n + 1];
            array[1] = 1;
            array[2] = 2;
    
            for (int i = 3; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
    
            return array[n];
        }
    }
}
