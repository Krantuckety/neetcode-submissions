public class Solution 
{
    public int FindMin(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        int min = 2147483647;

        while(left <= right)
        {
            mid = (left + right) / 2;
            if(nums[left] < nums[right] || nums[mid] < nums[right])
                right = mid - 1;
            else
                left = mid + 1;
            if(nums[mid] < min)
                min = nums[mid];
        }
        return min;
    }
}
