namespace Leetcode15
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            var length = nums.Length;
            Array.Sort<int>(nums);
            for (int i = 0; i < length - 2; i++)
            {
                var need = 0 - nums[i];
                int[] tmp = new int[length - i - 1];
                Array.Copy(nums, i + 1, tmp, 0, length - i - 1);
                var twoSum = TwoSum(tmp, need);
                foreach (var item in twoSum)
                {
                    item.Add(nums[i]);
                    res.Add(new List<int>(item));
                }
                while (i < length - 1 && nums[i] == nums[i + 1]) i++;
            }

            return res;
        }

        private IList<IList<int>> TwoSum(int[] nums, int target)
        {
            var res = new List<IList<int>>();
            var length = nums.Length;
            var lo = 0;
            var hi = length - 1;
            while (lo < hi)
            {
                var left = nums[lo];
                var right = nums[hi];
                var sum = left + right;
                if (sum > target)
                {
                    while (lo < hi && right == nums[hi]) hi--;
                }
                if (sum < target)
                {
                    while (lo < hi && left == nums[lo]) lo++;
                }
                if (sum == target)
                {
                    res.Add(new List<int> { nums[lo], nums[hi] });
                    while (lo < hi && right == nums[hi]) hi--;
                    while (lo < hi && left == nums[lo]) lo++;
                }
            }
            return res;
        }
    }
}