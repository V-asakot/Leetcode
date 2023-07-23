// each question have own branch
using System.Collections.Generic;

IList<IList<int>> Permute(int[] nums)
{
    var res = new List<IList<int>>();
    var current = new LinkedList<int>();
    void DFS(List<int> nums)
    {
        if (nums.Count == 0)
        {
            res.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Count; i++)
        {
            int currentNum = nums[i];

            current.AddLast(currentNum);
            nums.RemoveAt(i);

            DFS(nums);
            current.RemoveLast();
            nums.Insert(i, currentNum);
        }

    }
    DFS(nums.ToList());
    return res;
}