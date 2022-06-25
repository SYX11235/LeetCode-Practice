namespace Leetcode344
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l < r)
            {
                char tmp = s[l];
                s[l] = s[r];
                s[r] = tmp;
                l++;
                r--;
            }
        }
    }
}