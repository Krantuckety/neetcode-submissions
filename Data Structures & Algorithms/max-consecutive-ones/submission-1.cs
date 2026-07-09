public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int max = 0;
        int curr = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                curr++;
            }
            else
            {
                max = Math.Max(max, curr);
                curr = 0;
            }
        }
        max = Math.Max(max, curr);

        return max;
    }
}