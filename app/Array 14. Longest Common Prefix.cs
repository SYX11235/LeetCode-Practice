namespace Leetcode14
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int numberOfString = strs.Length;
            if (numberOfString == 0)
            {
                return "";
            }
            if (numberOfString == 1)
            {
                return strs[0];
            }
            bool reachEnd = false;
            bool notEqual = false;
            int LongestCommonPrefix = 0;
            int i = 0;
            for (i = 0; ; i++)
            {
                for (int j = 0; j < numberOfString - 1; j++)
                {
                    int currentLen = strs[j].Length;
                    int nextLen = strs[j + 1].Length;
                    if (i == currentLen || i == nextLen)
                    {
                        reachEnd = true;
                        break;
                    }
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        notEqual = true;
                        break;
                    }
                }
                if (reachEnd || notEqual)
                {
                    break;
                }
            }
            return strs[0].Substring(0, i - 1);
        }
    }
}