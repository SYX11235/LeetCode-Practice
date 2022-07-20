namespace Leetcode139
{
    public class Solution
    {
        HashSet<string> wordDictSet = new HashSet<string>();
        IList<string> wordDict = new List<string>();

        int[] memo;
        public bool WordBreak(string s, IList<string> wordDict)
        {
            this.wordDict = wordDict;
            this.wordDictSet = wordDict.ToHashSet();
            memo = new int[s.Length];
            Array.Fill<int>(memo, -1);
            return dp(s, 0);
        }

        private bool dp(string s, int i)
        {
            if (i == s.Length)
            {
                return true;
            }
            if (memo[i] != -1)
            {
                return memo[i] == 0 ? false : true;
            }
            foreach (var item in wordDict)
            {
                if (i + item.Length <= s.Length)
                {
                    var prefix = s.Substring(i, item.Length);
                    if (wordDictSet.Contains(prefix))
                    {
                        var sub = dp(s, i + item.Length);
                        if (sub == true)
                        {
                            memo[i] = 1;
                            return true;
                        }
                    }
                }
            }
            memo[i] = 0;
            return false;
        }
    }
}