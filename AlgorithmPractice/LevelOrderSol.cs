using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LevelOrderSol
    {

            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                IList<IList<int>> levelOrderResult = new List<IList<int>>();

                if (root == null) return levelOrderResult;

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int levelSize = queue.Count; // כמה צמתים יש ברמה הזאת
                    List<int> currentLevel = new List<int>();

                    for (int i = 0; i < levelSize; i++)
                    {
                        TreeNode node = queue.Dequeue();
                        currentLevel.Add(node.val);

                        if (node.left != null) queue.Enqueue(node.left);
                        if (node.right != null) queue.Enqueue(node.right);
                    }

                    levelOrderResult.Add(currentLevel);
                }

                return levelOrderResult;
            }
        
    }
}
