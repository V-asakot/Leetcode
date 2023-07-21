// each question have own branch

int CharacterReplacement(string s, int k)
{
    int res = 0;
    int l = 0;
    var count = new int[26];

    int maxInArray()
    {
        int max = count[0];
        foreach (int num in count)
            if (num > max) max = num;
        return max;
    }

    for (int r = 0; r < s.Length; r++)
    {
        count[s[r] - 65]++;
        while ((r - l + 1) - maxInArray() > k)
        {
            count[s[l] - 65]--;
            l++;
        }
        int subLenth = r - l + 1;
        if (subLenth > res) res = subLenth;

    }
    return res;
}

