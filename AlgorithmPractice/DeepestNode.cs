using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class DeepestNode
    {
        public static int DeepestNodeValue(TreeNode root)
        {
            if (root == null) return -1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode current = null;
            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            return current.val; 
        }
    }
}
