namespace LeetCode322
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                dp[i] = amount + 1;
            }

            for (int i = 1; i <= amount; i++)
            {
                foreach (var coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] = Math.Min(dp[i - coin] + 1, dp[i]);
                    }

                }
            }
            return dp[amount] == amount + 1 ? -1 : dp[amount];
        }
    }
}

