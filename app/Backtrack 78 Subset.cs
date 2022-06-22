public class Solution78
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    public IList<IList<int>> Subsets(int[] nums)
    {
        Backtrack(nums, 0);
        return res;
    }
    private void Backtrack(int[] nums, int start)
    {
        res.Add(track);
        for (int i = start; i < nums.Length; i++)
        {
            track.Add(nums[i]);
            this.Backtrack(nums, i + 1);
            track.RemoveAt(track.Count - 1);
        }
    }
}
