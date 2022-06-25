namespace Leetcode198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int length = nums.Length;
            int[] dp = new int[length + 1];
            dp[0] = 0;
            dp[1] = nums[0];

            for (int i = 1; i < length; i++)
            {
                dp[i + 1] = Math.Max(dp[i], dp[i - 1] + nums[i]);
            }
            return dp[length];
        }
    }
}