namespace Leetcode452
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            int length = points.Length;
            if (length == 0)
            {
                return 0;
            }
            Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));
            int pointsEnd = points[0][1];
            int NoOfArrows = 1;
            foreach (var item in points)
            {
                if (item[0] <= pointsEnd)
                {
                   continue;
                }
                else
                {
                    pointsEnd = item[1];
                    NoOfArrows++;
                }
            }
            return NoOfArrows;
        }
    }
}