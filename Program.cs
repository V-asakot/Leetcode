bool SearchMatrix(int[][] matrix, int target)
{
    int h = matrix[0].Length, v = matrix.Length;
    for (int i =0;i< v;i++ )
    {
        var array = matrix[i];
        if (array[0] <= target && array[h - 1] >= target)
        {
            int l = 0, r = h - 1;
            int c = (l+r)/2;
            while (l <= r)
            {
                int val = array[c];
                if (target < val) r = c - 1;
                else if (target > val) l = c + 1;
                else return true;
                c = (l + r) / 2;
            }
            return false;
        }
    }

    return false;
}

SearchMatrix(new int[][]{new int[]{ 1, 3, 5, 7 }, new int[] { 10,11,16,20 }, new int[] { 23,30,34,60 }}, 3);
//SearchMatrix(new int[][] { new int[] { -10, -8, -8, -8 }, new int[] { -5, -4, -2, 0 } }, 7);