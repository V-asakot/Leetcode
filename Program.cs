using System;
// each question have own branch
public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
{
    Array.Sort(candidates);
    var length = candidates.Length;
    var res = new List<IList<int>>();
    void dfs(int pointer, List<int> current,int total)
    {
        int val = -1;
        for(int i=0;i<length;i++)
        {
            if(val == candidates[i]) continue;
            current.Add(val);
            dfs(++pointer, current, total+val);
            current.RemoveAt(current.Count-1);
            val = candidates[i];
        }
    }

    dfs(0,new List<int>(),0);
    return res;   
}