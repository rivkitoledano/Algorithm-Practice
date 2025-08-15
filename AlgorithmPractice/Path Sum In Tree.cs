using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class Path_Sum_In_Tree
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null)
                return targetSum == root.val;

            return HasPathSum(root.left, targetSum - root.val) ||
                   HasPathSum(root.right, targetSum - root.val);
        }

    }
}
