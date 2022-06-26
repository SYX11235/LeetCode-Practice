namespace Leetcode104
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
        private int res = 0;
        private int currentDeepth = 0;
        public int MaxDepth(TreeNode root)
        {
            TraverseTree(root);
            return res;
        }

        private void TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            currentDeepth++;
            if (root.left == null && root.right == null)
            {
                res = Math.Max(res, currentDeepth);
            }
            TraverseTree(root.left);
            TraverseTree(root.right);
            currentDeepth--;
        }

        private int GetMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = GetMaxDepth(root.left);
            var right = GetMaxDepth(root.right);

            return left > right ? left + 1 : right + 1;
        }
    }
}