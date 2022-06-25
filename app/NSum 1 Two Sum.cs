namespace Leetcode1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            var dic = new Dictionary<int, int>();
            if (nums.Length == 0 || nums.Length == 1)
            {
                return res;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var need = target - nums[i];
                if (dic.ContainsKey(need))
                {
                    return new int[] { i, dic[need] };
                }
                else if (dic.ContainsKey(nums[i]))
                {
                    if (need == nums[i])
                    {
                        return new int[] { dic[nums[i]], i };
                    }
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }
            return res;
        }
    }
}