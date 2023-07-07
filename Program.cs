// each question have own branch

IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    var res = new List<IList<int>>();
    void dfs(int pointer, List<int> current,int total)
    {
        if (total == target)
        {
            res.Add(new List<int>(current));
            return;
        }

        if (pointer >= candidates.Length || total > target) return;
        int val = candidates[pointer];
        current.Add(val);
        dfs(pointer, current, total+val);
        current.Remove(val);
        dfs(pointer+1, current, total);
    }

    dfs(0,new List<int>(),0);
    return res;
}