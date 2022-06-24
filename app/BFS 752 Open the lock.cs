public class Solution752
{
    String plusOne(String s, int j)
    {
        char[] ch = s.ToCharArray();
        if (ch[j] == '9')
            ch[j] = '0';
        else
            ch[j] = (Char)(Convert.ToUInt16(ch[j]) + 1);
        return new String(ch);
    }

    String minusOne(String s, int j)
    {
        char[] ch = s.ToCharArray();
        if (ch[j] == '0')
            ch[j] = '9';
        else
            ch[j] = (Char)(Convert.ToUInt16(ch[j]) - 1); ;
        return new String(ch);
    }

    public int OpenLock(String[] deadends, String target)
    {
        Queue<String> q = new Queue<String>();
        q.Enqueue("0000");
        HashSet<String> visited = new HashSet<string>();
        foreach (var item in deadends)
        {
            visited.Add(item);
        }
        int step = 0;

        while (q.Count != 0)
        {
            int sz = q.Count();
            for (int i = 0; i < sz; i++)
            {
                String cur = q.Dequeue();
                
                if (cur == target)
                {
                    return step;
                }

                if (visited.Contains(cur))
                {
                    continue;
                }

                visited.Add(cur);

                for (int j = 0; j < 4; j++)
                {
                    String up = plusOne(cur, j);
                    if (!visited.Contains(up))
                    {
                        q.Enqueue(up);
                    }

                    String down = minusOne(cur, j);
                    if (!visited.Contains(down))
                    {
                        q.Enqueue(down);
                    }
                }
            }
            step++;
        }
        return -1;
    }
}
