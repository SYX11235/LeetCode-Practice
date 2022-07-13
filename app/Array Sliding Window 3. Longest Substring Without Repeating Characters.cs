namespace Leetcode3
{
     public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;
            if (length == 0)
            {
                return 0;
            }
            int left = 0;
            int right = 0;
            int[] chars = new int[128];
            int maxSubStringLength = 0;
            while (right < length)
            {
                char c = s[right];
                chars[c]++;
                while (chars[c] > 1)
                {
                    chars[s[left]]--;
                    left++;
                }
                
                maxSubStringLength = Math.Max(maxSubStringLength, right - left + 1);
                right++;
            }
            return maxSubStringLength;

        }
    }
}
