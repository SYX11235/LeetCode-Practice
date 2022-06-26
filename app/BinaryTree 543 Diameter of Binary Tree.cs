namespace Leetcode543
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        int maxDiameter = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            GetMaxDepth(root);
            return maxDiameter;
        }

        private int GetMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int maxLeft = GetMaxDepth(root.left);
            int maxRight = GetMaxDepth(root.right);
            int currentDiameter = maxLeft + maxRight;
            maxDiameter = Math.Max(currentDiameter, maxDiameter);
            return Math.Max(maxLeft, maxRight) + 1;
        }
    }
}