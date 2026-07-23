public class Solution 
{
    public int Rob(int[] nums) 
    {
        int[] money = new int[nums.Length];
        int prev1 = 0, prev2 = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(0 < i)
            {
                prev1 = money[i-1];
                if(1 < i)
                {
                    prev2 = money[i-2];
                }
            }

            money[i] = Math.Max(prev1, nums[i] + prev2);
        }

        return money[nums.Length - 1];
    }
}
