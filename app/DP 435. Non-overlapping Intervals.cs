namespace Leetcode435
{
     public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            int numberOfInternals = intervals.Length;
            int numberToBeDeleted = 0;
            int endOfInterval = int.MinValue;
            Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
            foreach (var interval in intervals)
            {
                if (interval[0] >= endOfInterval)
                {
                    endOfInterval = interval[1];
                    continue;
                }
                numberToBeDeleted++;
              
            }
            return numberToBeDeleted;
        }
    }
}