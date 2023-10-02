using System;
// each question have own branch

int LeastInterval(char[] tasks, int n) 
{
        if (0 == n) return tasks.Length;

        var counts = tasks
            .GroupBy(x => x)
            .Select(x => x.Count());

        int chCount = 0, maxCount = 0, ans = 0;
        foreach(var count in counts)
        {
            if (count > maxCount)
            {
                chCount = 1; maxCount = count;
            }
            else if (count == maxCount)
            {
                chCount++;
            }
        }
        ans = (maxCount - 1) * (n + 1) + chCount;
        if (ans >= tasks.Length) return ans;
        return tasks.Length;
}