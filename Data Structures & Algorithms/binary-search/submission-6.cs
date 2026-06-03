public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int checkNum = left + (right - left) / 2;

            if(nums[checkNum] == target)
                return checkNum;
            
            if(nums[checkNum] < target)
                left = checkNum + 1;
            else
                right = checkNum - 1;
        }

        return -1;
    }
}
