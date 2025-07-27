namespace AlgorithmPractice
{
    public class TreeNode
    {
        public TreeNode() { }
        public TreeNode(int val)
        {
            this.val = val;
        }
        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public int val;
        public TreeNode left;
        public TreeNode right;
        public override string ToString()
        {
            return $"TreeNode(val: {val}, left: {left?.val}, right: {right?.val})";
        }
    }
}