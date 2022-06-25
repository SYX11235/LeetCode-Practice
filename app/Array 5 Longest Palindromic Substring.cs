namespace Leetcode5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {

                var s1 = FindPalindrome(s, i, i);
                var s2 = FindPalindrome(s, i, i + 1);
                var tmp = s1.Length > s2.Length ? s1 : s2;
                res = res.Length > tmp.Length ? res : tmp;
            }
            return res;
        }

        private string FindPalindrome(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length)
            {
                if (s[l] == s[r])
                {
                    l--;
                    r++;
                }
                else break;
            }
            return s.Substring(l + 1, r - l - 1);
        }
    }
}