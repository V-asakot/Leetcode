// each question have own branch
int[] ProductExceptSelf(int[] nums)
{
    var output = new int[nums.Length];
    int prefix = 1;
    for (int i = 0;i < nums.Length;i++)
    {
        output[i] = prefix;
        prefix *= nums[i];
    }
    int postfix = 1;
    for (int i = nums.Length; i >= 0; i--)
    {
        output[i] *= postfix;
        prefix *= nums[i];
    }
    return output;
}