// each question have own branch
int MaxProfit(int[] prices)
{
    int l = 0, r = 1, maxProfit = 0;
    for (int i=1;i < prices.Length;i++)
    {
        int profit = prices[r] - prices[l];
        if (profit > maxProfit) maxProfit = profit;
        if (prices[r] < prices[l])
        {
            l = r;
        }
        r++;
    }
    return maxProfit;
}