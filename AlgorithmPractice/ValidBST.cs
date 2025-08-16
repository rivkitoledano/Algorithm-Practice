using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class ValidBST
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValid(root, int.MinValue, int.MaxValue);
        }

        private bool IsValid(TreeNode node, long min, long max)
        {
            if (node == null) return true;
            if (node.val <= min || node.val >= max) return false;
            return IsValid(node.left, min, node.val) &&
                   IsValid(node.right, node.val, max);
        }
    }
}
