﻿// each question have own branch
int MinEatingSpeed(int[] piles, int h)
{
    int max = piles[0];
    foreach (int pile in piles)
    {
        if (pile > max) max = pile;
    }
    int res = max;
    int l = 0, r = max;
    while (l <= r)
    {
        int k = (l + r) / 2;
        int hours = 0;
        foreach (int pile in piles) hours += (int)Math.Ceiling((double)pile / k);
        if (hours <= h)
        {
            res = res < k ? res : k;
            r = k - 1;
        }
        else l = k + 1;

    }
    return res;
}