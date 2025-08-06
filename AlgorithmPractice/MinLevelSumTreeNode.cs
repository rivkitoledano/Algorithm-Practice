using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class MinLevelSumTreeNode
    {
        public static int MinLevelSum(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int minSum = int.MaxValue;
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int currentLevelSum = 0;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevelSum += currentNode.val;
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
                minSum = Math.Min(minSum, currentLevelSum);
            }
            return minSum;
        }
    }
}
