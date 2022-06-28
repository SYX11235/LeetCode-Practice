namespace Leetcode53
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int res = int.MinValue;
            int length = nums.Length;
            int[] dp = new int[length];
            dp[0] = nums[0];
            for (int i = 1; i < length; i++)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
            }

            for (int i = 0; i < length; i++)
            {
                res = Math.Max(res, dp[i]);
            }

            return res;
        }
    }
}