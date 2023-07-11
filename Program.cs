// each question have own branch

IList<IList<int>> ThreeSum(int[] nums)
{
    var res = new List<IList<int>>();
    Array.Sort(nums);
    int prev = -1;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i > 0 && prev == nums[i]) continue;
        int first = nums[i];
        int l = i + 1, r = nums.Length - 1;

        while (l < r)
        {
            int sum = first + nums[l] + nums[r];
            if (sum > 0) r--;
            else if (sum < 0) l++;
            else
            {
                res.Add(new List<int>() { first, nums[l], nums[r] });
                l++;
                while (nums[l - 1] == nums[l] && l < r) l++;
            }
        }
        prev = nums[i];
    }

    return res;
}