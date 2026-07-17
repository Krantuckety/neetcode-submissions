public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int, int> counts = new();

        foreach(int n in nums)
        {
            if(counts.ContainsKey(n))
                counts[n]++;
            else
                counts[n] = 1;
        }

        int highestCount = 0;
        int mostFrequentNum = 0;

        foreach(var n in counts)
        {
            if(n.Value > highestCount)
            {
                highestCount = n.Value;
                mostFrequentNum = n.Key;
            }
        }

        return mostFrequentNum;
    }
}