public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int minPrice = int.MaxValue;
        int output = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < minPrice)
                minPrice = prices[i];
            else
                output = Math.Max(output, (prices[i] - minPrice));
        }

        return output;
    }
}
