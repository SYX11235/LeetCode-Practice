namespace Leetcode83
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            var slow = head;
            var fast = head;
            while (fast != null)
            {
                if (fast.val != slow.val)
                {
                    slow = slow.next;
                    slow.val = fast.val;
                }
                fast = fast.next;
            }
            slow.next = null;
            return head;
        }
    }
}