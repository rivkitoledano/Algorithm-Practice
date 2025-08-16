using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class IsSymmetric
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
                return false;
            return IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
        }
        public bool IsSymmetricTree(TreeNode root)
        {
            if (root == null)
                return true;
            return IsSameTree(root.left, root.right);
        }
    }
}
