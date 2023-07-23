// each question have own branch
using System.Collections.Generic;

IList<IList<int>> Permute(int[] nums)
{
        var res = new List<IList<int>>();
        var current = new List<int>();
        void DFS(List<int> nums)
        {
            if (nums.Count == 0) 
            {
                res.Add(new List<int>(current));
                return; 
            }

            for (int i=0;i < nums.Count; i++)
            {
                int currentNum = nums[i];

                current.Add(currentNum);
                nums.RemoveAt(i);

                DFS(nums);
                current.RemoveAt(current.Count-1);
                nums.Insert(i,currentNum);
            }

        }
        DFS(nums.ToList());
        return res;
}