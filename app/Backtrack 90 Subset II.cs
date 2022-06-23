public class Solution90
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    public IList<IList<int>> Subsets2(int[] nums)
    {
        Array.Sort(nums);
        Backtrack(nums, 0);
        return res;
    }
    private void Backtrack(int[] nums, int start)
    {
        res.Add(new List<int>(track));
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
            {
                continue;
            }
            track.Add(nums[i]);
            this.Backtrack(nums, i + 1);
            track.RemoveAt(track.Count - 1);
        }
    }
}