public class Solution122 {
    public int MaxProfit(int[] prices) {
        var length = prices.Length;
        int[,] dp = new int[length, 2];

        dp[0, 0] = 0;
        dp[0, 1] = 0 - prices[0];

        for (int i = 1; i < length; i++)
        {
            dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
            dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
        }

        return dp[length - 1, 0];
    }
}