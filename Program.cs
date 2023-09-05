// each question have own branch

IList<IList<int>> SubsetsWithDup(int[] nums)
{
    int length = nums.Length;
    Array.Sort(nums);
    var indexes = new Dictionary<int, int>();
    for (int i = 0; i < length - 1; i++)
    {
        if(nums[i] != nums[i+1]) indexes[nums[i]] = i;
    }

    IList<IList<int>> res = new List<IList<int>>();
    List<int> current = new List<int>();
    void DFS(int i)
    {
        if (i >= length)
        {
            res.Add(new List<int>(current));
            return;
        }

        current.Add(nums[i]);
        DFS(i + 1);
        current.RemoveAt(current.Count() - 1);
        DFS(indexes[nums[i]] + 1);
    }
    DFS(0);
    return res;
}