public class Solution 
{
    public int ScoreOfString(string s) 
    {
        int result = 0;
        for(int i = 1; i < s.Length; i++)
        {
            int a = (int) s[i-1];
            int b = (int) s[i];
            result += Math.Abs(b-a);
        }
        return result;
    }
}