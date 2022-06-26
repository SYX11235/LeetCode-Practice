namespace Leetcode116
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Traverse(root.left, root.right);
            return root;
        }

        private void Traverse(Node node1, Node node2)
        {
            if (node1 == null || node2 == null)
            {
                return;
            }
            node1.next = node2;
            Traverse(node1.left, node1.right);
            Traverse(node1.right, node2.left);
            Traverse(node2.left, node2.right);
        }
    }
}