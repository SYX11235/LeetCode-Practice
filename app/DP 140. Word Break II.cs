namespace Leetcode140
{
    public class Solution
    {
        IList<string> track = new List<string>();
        IList<string> wordDict = new List<string>();
        IList<string>[] memo;
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            int length = s.Length;
            this.wordDict = wordDict;
            memo = new List<string>[s.Length];
            return dp(s, 0).Distinct().ToList();
        }

        private IList<string> dp(string s, int i)
        {
            List<String> res = new List<string>();
            if (i == s.Length)
            {
                res.Add("");
                return res;
            }
            if (memo[i] != null)
            {
                return memo[i];
            }
            foreach (var word in wordDict)
            {
                int length = word.Length;
                if (i + length <= s.Length)
                {
                    var prefix = s.Substring(i, length);
                    if (wordDict.Contains(prefix))
                    {
                        var sub = dp(s, i + length);
                        foreach (var item in sub)
                        {
                            if (item.Length == 0)
                            {
                                res.Add(prefix);
                            }
                            else
                            {
                                res.Add(prefix + " " + item);
                            }
                        }
                    }
                }
            }
            memo[i] = res;
            return res;
        }
    }
}