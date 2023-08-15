// each question have own branch

int FindMin(int[] nums)
{
    int min = nums[0];
    int l = 0, r = nums.Length - 1;
    while (l <= r)
    {
        if (nums[l] < nums[r])
        {
            if (min > nums[l]) min = nums[l];
            break;
        }

        int middle = r + l / 2;
        if (min > nums[middle]) min = nums[middle];
        if (nums[middle] >= nums[l])
        {
            l = middle + 1;
        }
        else
        {
            r = middle - 1;
        }
    }
    return min;
}