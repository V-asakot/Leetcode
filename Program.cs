// 12321 1221 12 123

string LongestPalindrome(string s)
{
    var resultL = 0;
    var resLength = 0;

    void checkForPalindrome(int l,int r)
    {
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            if (r - l + 1 > resLength)
            {
                resLength = r - l + 1;
                resultL = l;
            }

            l--;
            r++;
        }
    }

    for(int i =0; i<s.Length; i++)
    {
        var l, r = i;
        checkForPalindrome();

        l = i;
        r = i + 1;

        checkForPalindrome();
    }

    return s.Substring(resultL, resLength);
}