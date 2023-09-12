// each question have own branch

bool CanJump(int[] nums)
{
    int length = nums.Length;
    var target = length - 1;
    for (int i = target - 1; i >= 0; i--)
    {
        if (i + nums[i] >= target)
        {
            target = i; 
        }
    }

    return target == 0;
}