using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class Intersection
    {
        public int[] HelpIntersection(int[] nums1, int[] nums2, HashSet<int> set)
        {
            HashSet<int> setNums2 = new HashSet<int>(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                if (setNums2.Contains(nums1[i]))
                {
                    set.Add(nums1[i]);
                }
            }
            return set.ToArray();
        }
        public int[] IntersectionSol(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            if (nums1.Length > nums2.Length)
            {
                return HelpIntersection(nums2, nums1, set);
            }
            else
            {
                return HelpIntersection(nums1, nums2, set);

            }

        }
    }
}
