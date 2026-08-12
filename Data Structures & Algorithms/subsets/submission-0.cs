public class Solution 
{
    public List<List<int>> Subsets(int[] nums) 
    {
        List<List<int>> output = new();
        output.Add(new List<int>());

        for(int i = 0; i < nums.Length; i++)
        {
            int n = nums[i];
            int count = output.Count;
            for(int j = 0; j < count; j++)
            {
                List<int> l = new List<int>(output[j]);
                l.Add(n);
                output.Add(l);
            }
        }

        return output;
    }
}
