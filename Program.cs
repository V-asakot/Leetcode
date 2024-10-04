IList<string> RemoveInvalidParentheses(string s)
{
    int longestString = -1;
    int length = s.Length;  
    var res = new HashSet<string>();

    DFS(0, "", 0, 0);

    void DFS(int index, string str, int l, int r) 
    {
        if (index == length)
        {
            if (l == r)
            {
                if (str.Length > longestString)
                {
                    longestString = str.Length;
                    res = new HashSet<string>() { str.ToString() };
                }
                else if (str.Length == longestString)
                {
                    res.Add(str.ToString());
                }
            }
        }
        else
        {
            var cur = s[index];
            if (cur == '(')
            {
                DFS(index + 1, str + cur, l + 1, r);

                DFS(index + 1, str, l, r);
            }
            else if (cur == ')') 
            {
                DFS(index + 1, str, l, r);

                if (r < l) 
                {
                    DFS(index + 1, str + cur, l, r + 1);
                }
            }
            else
            {
                DFS(index + 1, str + cur, l, r);
            }
        }
    }

    return res.ToList();
}