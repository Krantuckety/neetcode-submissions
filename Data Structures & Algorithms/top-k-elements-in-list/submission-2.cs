public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict[nums[i]] = 1;
        }
        var dictSortedByFrequency = dict.OrderByDescending(x => x.Value);

        int[] output = new int[k];
        for(int i = 0; i < k; i++)
        {
            output[i] = dictSortedByFrequency.ElementAt(i).Key;
        }
        return output;
    }
}
