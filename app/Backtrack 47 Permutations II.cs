public class Solution47
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    private Boolean[] used;
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        used = new Boolean[nums.Length];
        Backtrack(nums);
        return res;
    }

    private void Backtrack(int[] nums)
    {
        if (track.Count == nums.Length)
        {
            res.Add(new List<int>(track));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i] == true)
            {
                continue;
            }
            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
            {
                continue;
            }
            track.Add(nums[i]);
            used[i] = true;
            Backtrack(nums);
            track.RemoveAt(track.Count - 1);
            used[i] = false;
        }
    }
}