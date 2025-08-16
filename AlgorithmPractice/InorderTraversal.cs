using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class InorderTraversal
    {
        public IList<int> InorderTraversalSol(TreeNode root)
        {
            List<int> res = new List<int>();
            InorderTraversalRec(res, root);
            return res;
        }
        public void InorderTraversalRec(List<int> res, TreeNode root)
        {
            if (root == null)
                return;
            InorderTraversalRec(res, root.left);
            res.Add(root.val);
            InorderTraversalRec(res, root.right);
        }
    }
}
