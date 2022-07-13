namespace Leetcode135
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int length = ratings.Length;
            if (length == 0)
            {
                return 0;
            }

            int[] l2r = new int[length];
            int[] r2l = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                l2r[i] = 1;
                r2l[i] = 1;
            }

            for (int i = 1; i < length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    l2r[i] = l2r[i - 1] + 1;
                }

                if (ratings[length - i] < ratings[length - i - 1])
                {
                    r2l[length - i - 1] = r2l[length - i] + 1;
                }
            }

            for (int i = 0; i < length; i++)
            {
                result[i] = Math.Max(l2r[i], r2l[i]);
            }

            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = sum + result[i];
            }

            return sum;
        }
    }
}
