IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dict = new Dictionary<int, IList<string>>();
    foreach (var s in strs)
    {
        var count = new int[26];
        foreach (var ch in s)
        {
            count[((int)ch) - 97]++;
        }
        int key = GetHashCodeCustom(count);
        Console.WriteLine(key);
        dict[key] = dict.TryGetValue(key, out IList<string> value) 
            ? value.Append(s).ToList() 
            : new List<string>() { s };
    }
    return dict.Values.ToList();
}

int GetHashCodeCustom(int[] array)
{
    int hc = array.Length;
    foreach (int val in array)
    {
        hc = unchecked(hc * 314159 + val);
    }
    return hc;
}

GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });



