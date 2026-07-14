public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> threeSums = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            if(i != 0 && nums[i] == nums[i-1])
                continue;
            int pLeft = i + 1, pRight = nums.Length - 1;
            while(pLeft < pRight)
            {
                if(nums[pLeft] + nums[pRight] + nums[i] == 0)
                {
                    List<int> nextSum = new List<int> {nums[i], nums[pLeft], nums[pRight]};
                    threeSums.Add(nextSum);
                    pLeft++;
                    pRight--;
                    while(pLeft < pRight && nums[pLeft] == nums[pLeft - 1]){
                        pLeft++;
                    }
                    while(pLeft < pRight && nums[pRight] == nums[pRight + 1]){
                        pRight--;
                    }
                }
                else if(nums[pLeft] + nums[pRight] + nums[i] > 0)
                {
                    pRight--;
                }
                else
                {
                    pLeft++;
                }
            }
        }
        
        return threeSums;
    }
}
