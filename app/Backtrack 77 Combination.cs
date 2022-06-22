public class Solution77
{
    private IList<IList<int>> res = new List<IList<int>>();
    private List<int> track = new List<int>();
    public IList<IList<int>> Combine(int n, int k)
    {
        Backtrack(1, n, k);
        return res;
    }

    private void Backtrack(int start, int n, int k)
    {
        if (track.Count == k)
        {
            res.Add(track);
            return;
        }
        for (int i = start; i <= n; i++)
        {
            track.Add(i);
            Backtrack(i + 1, n, k);
            track.RemoveAt(track.Count - 1);

        }
    }
}