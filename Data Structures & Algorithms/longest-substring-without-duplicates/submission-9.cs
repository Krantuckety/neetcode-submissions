public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int maxLen = 0;
        int j = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                j = Math.Max(j, dict[s[i]] + 1);
            }
            dict[s[i]] = i;
            maxLen = Math.Max(maxLen, i - j + 1);
        }
        return maxLen;
    }
}
