// each question have own branch

int ClimbStairs(int n)
{
    if (n <= 2) return n;
    int first = 1, second = 2;
    for (int i=2;i<n;i++)
    {
        int sum = first + second;
        first = second;
        second = sum;
    }
    return second;
}