public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        StringBuilder sb = new StringBuilder(strs[0], 200);
        int prefixSize = strs[0].Length;
        foreach(string str in strs)
        {
            for(int i = 0; i < prefixSize; i++)
            {
                if(i >= str.Length || str[i] != sb[i])
                {
                    prefixSize = i;
                    break;
                }
            }
        }

        sb.Remove(prefixSize, sb.Length - prefixSize);
        return sb.ToString();
    }
}