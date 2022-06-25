namespace Leetcode26
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            int fast = 0;
            int slow = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    fast = i + 1;
                    slow = slow + 1;
                    nums[slow] = nums[i + 1];
                }
            }
            return slow + 1;
        }
    }
}