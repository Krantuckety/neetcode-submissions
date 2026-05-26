public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int sum = 1;
        int sumWithoutZero = 1;
        int[] output = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                sumWithoutZero = sum;
            else
                sumWithoutZero *= nums[i];
            sum *= nums[i];
        }
        for(int j = 0; j < nums.Length; j++)
        {
            if(nums[j] != 0)
            {
                output[j] = (sum / nums[j]);
            }
            else
            {
                output[j] = sumWithoutZero;
            }
        }
        return output;
    }
}
