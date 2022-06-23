public class Solution40
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    private int trackSum;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        if (candidates.Length == 0)
        {
            return res;
        }
        Array.Sort(candidates);
        Backtrack(candidates, 0, target);
        return res;
    }
    private void Backtrack(int[] nums, int start, int target)
    {
        if (trackSum == target)
        {
            res.Add(new List<int>(track));
            return;
        }
        if (trackSum > target)
        {
            return;
        }
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
            {
                continue;
            }
            track.Add(nums[i]);
            trackSum = trackSum + nums[i];
            this.Backtrack(nums, i + 1, target);
            track.RemoveAt(track.Count - 1);
            trackSum = trackSum - nums[i];
        }
    }
}