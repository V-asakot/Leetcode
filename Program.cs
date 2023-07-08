// each question have own branch
int LengthOfLongestSubstring(string s)
{
    int max = 0,l = 0;
    var table = new HashSet<int>();
    for (int r=0;r<s.Length;r++)
    {
        while (table.Contains(s[r]))
        {
            table.Remove(s[l]);
            l++;
        }
        table.Add(s[r]);
        int diff = r - l + 1;
        if (diff > max) max = diff;
    }

    return max;
}