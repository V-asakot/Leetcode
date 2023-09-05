// each question have own branch

IList<IList<int>> SubsetsWithDup(int[] nums)
{
    int length = nums.Length;
    Array.Sort(nums);
    IList<IList<int>> res = new List<IList<int>>();
    List<int> current = new List<int>();
    void DFS(int i)
    {
        if (i >= length)
        {
            res.Add(new List<int>(current));
            return;
        }

        int curr = nums[i];
        current.Add(curr);
        int step = i + 1;  
        DFS(step);
        current.RemoveAt(current.Count() - 1);
        while (step < length && nums[step] == curr)
        {
            step++;
        }
        DFS(step);
    }
    DFS(0);
    return res;
}