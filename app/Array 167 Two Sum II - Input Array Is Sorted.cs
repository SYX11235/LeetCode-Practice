namespace Leetcode167
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int length = numbers.Length;
            int hi = length - 1;
            int lo = 0;
            while (lo < hi)
            {
                int sum = numbers[lo] + numbers[hi];
                if (sum == target)
                {
                    return new int[]{lo + 1, hi + 1};
                }
                if (sum > target)
                {
                    hi--;
                }
                if (sum < target)
                {
                    lo++;
                }
            }
            return new int[]{};
        }
    }
}