// each question have own branch
int Rob(int[] nums)
{
    int maxFirst = 0, maxSecond = 0;
    foreach (int num in nums )
    {
        int temp = maxFirst + num > maxSecond ? maxFirst + num : maxSecond;
        maxFirst = maxSecond;
        maxSecond = temp;
    }
    return maxSecond;
}