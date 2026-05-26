public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1)
            return 1;

        int[] sortedNums = nums;
        Array.Sort(sortedNums);
        int output = 1;
        int currentSeqLen = 1;

        for(int i = 1; i < sortedNums.Length; i++)
        {
            if(sortedNums[i] == sortedNums[i-1] + 1)
            {
                currentSeqLen++;
                if(currentSeqLen > output)
                    output = currentSeqLen;
            }
            else if(sortedNums[i] == sortedNums[i-1])
            {
                if(currentSeqLen > output)
                    output = currentSeqLen;
            }
            else
            {
                currentSeqLen = 1;
            }
        }

        return output;
    }
}
