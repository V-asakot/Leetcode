// each question have own branch

int Jump(int[] nums)
{
    if (nums.Length == 1) return 0;
    int l = 1, r = nums[0];
    int level = 1;
    while (r < nums.Length - 1)
    {
        int cur = 0;
        int farthest = 0;
        for (int i = l; i < r + 1; i++)
        {
            farthest = farthest > (cur = i + nums[i]) ? farthest : cur;
        }
        l = r + 1;
        r = farthest;
        level++;
    }

    return level;
}