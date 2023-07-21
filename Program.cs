// each question have own branch

int CharacterReplacement(string s, int k)
{
    int res = 0;
    int l = 0;
    var count = new int[26];

    int max = 0;
    for (int r = 0; r < s.Length; r++)
    {
        int key = s[r] - 65;
        count[key]++;
        if (count[key] > max) max = count[key];
        while ((r - l + 1) - max > k)
        {
            count[s[l] - 65]--;
            l++;
        }
        int subLenth = r - l + 1;
        if (subLenth > res) res = subLenth;

    }
    return res;
}

