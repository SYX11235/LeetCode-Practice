namespace Leetcode309
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var length = prices.Length;
            if (length == 0 || length == 1)
            {
                return 0;
            }

            var dp = new int[length, 2];
            dp[0, 0] = 0;
            dp[0, 1] = 0 - prices[0];
            dp[1, 0] = Math.Max(0, dp[0, 1] + prices[1]);
            dp[1, 1] = Math.Max(0 - prices[0], 0 - prices[1]);
            for (int i = 2; i < length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 2, 0] - prices[i]);
            }

            return dp[length - 1, 0];
        }
    }
}

