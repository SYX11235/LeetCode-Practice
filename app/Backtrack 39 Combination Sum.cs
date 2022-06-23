public class Solution39
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    private int trackSum;
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        if (candidates.Length == 0)
        {
            return res;
        }
        Backtrack(candidates, 0, target);
        return res;
    }

    private void Backtrack(int[] candidates, int start, int target)
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

        for (int i = start; i < candidates.Length; i++)
        {
            track.Add(i);
            trackSum = trackSum + candidates[i];
            this.Backtrack(candidates, i, target);
            track.RemoveAt(track.Count - 1);
            trackSum = trackSum - candidates[i];
        }
        
    }
    

}