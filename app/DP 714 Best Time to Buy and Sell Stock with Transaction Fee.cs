namespace Leetcode714
{
    public class Solution
    {
        public int MaxProfit(int[] prices, int fee)
        {
            var length = prices.Length;
            if (length == 0 || length == 1)
            {
                return 0;
            }

            var dp = new int[length, 2];
            dp[0, 0] = 0;
            dp[0, 1] = 0 - prices[0] - fee;
            for (int i = 1; i < length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i] - fee);
            }

            return dp[length - 1, 0];
        }
    }
}