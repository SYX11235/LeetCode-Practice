namespace Leetcode473
{
    public class Solution
    {
        int[] sideLength = new int[4];

        int target;
        public bool Makesquare(int[] matchsticks)
        {
            var sum = matchsticks.Sum();
            if (sum % 4 != 0 || sum < 4)
            {
                return false;
            }
            this.target = sum / 4;
            return dfs(matchsticks, 0);
        }

        private bool dfs(int[] matchsticks, int index)
        {
            if (index == matchsticks.Length)
                return sideLength[0] == sideLength[1] && sideLength[1] == sideLength[2] && sideLength[2] == sideLength[3];

            for (int i = 0; i < 4; i++)
            {
                if (sideLength[i] + matchsticks[index] > this.target)
                {
                    continue;
                }

                int j = i;
                while (--j >= 0)
                    if (sideLength[i] == sideLength[j])
                        break;
                if (j != -1) continue;

                sideLength[i] = sideLength[i] + matchsticks[index];

                if (dfs(matchsticks, index + 1))
                {
                    return true;
                }

                sideLength[i] = sideLength[i] - matchsticks[index];
            }
            return false;
        }

    }
}