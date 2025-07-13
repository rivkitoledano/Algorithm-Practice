using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class BinarySearch
    {
        static public int BinSearch(int[] nums, int target)
        {
            int end = nums.Length - 1;
            int start = 0;
            int mid;    
            while (start <= end) {
                mid = (start + end) / 2;   
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1; // Target not found 
        }
    }
}
