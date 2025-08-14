using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class SortedArrayToBSTSolution
    {
        public TreeNode SortedArrayToBSTRec(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(nums[mid]); // <-- added "new"
            root.left = SortedArrayToBSTRec(nums, start, mid - 1);
            root.right = SortedArrayToBSTRec(nums, mid + 1, end);
            return root;

        }
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTRec(nums, 0, nums.Length - 1);
        }
    }
}
