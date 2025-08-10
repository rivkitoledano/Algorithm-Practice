using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class MergeArrays
    {
        public static int[] Merge(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr1.Length == 0) return arr2;
            if (arr2 == null || arr2.Length == 0) return arr1;
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }
            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }
            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }
            return mergedArray;
        }
    }
}
