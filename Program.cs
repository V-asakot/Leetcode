bool SearchMatrix(int[][] matrix, int target)
{
    int vertical = matrix.Length;
    int horizontal = matrix[0].Length;
    int l = 0, r = (vertical * matrix[0].Length)  - 1;
    while (r >= l)
    {
        int c = (l + r) / 2;
        int x = c / horizontal;
        int y = c % horizontal;
        int value = matrix[x][y];

        if (target > value) l = c + 1;
        else if (target < value) r = c - 1;
        else return true;
    }
    return false;
}

//SearchMatrix(new int[][]{new int[]{ 1, 3, 5, 7 }, new int[] { 10,11,16,20 }, new int[] { 23,30,34,60 }}, 76);
SearchMatrix(new int[][] { new int[] { -10, -8, -8, -8 }, new int[] { -5, -4, -2, 0 } }, 7);