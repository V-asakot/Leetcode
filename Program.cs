using System;
using System.Text;

string LongestCommonPrefix(string[] strs) 
{
    if(strs.Length == 1) return strs[0];
    var res = new StringBuilder("");
    for(int i = 0;i < strs[0].Length;i++)
    {
        var ch = strs[0][i];
        for(int j=1;j < strs.Length;j++)
        {   
            if(strs[j].Length <= i || ch != strs[j][i]) return res.ToString();
        }
        res.Append(ch);
    }
    return res.ToString();
}
