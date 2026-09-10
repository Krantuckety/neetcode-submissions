public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int b = 0, f = s.Length - 1;
        while(b < f)
        {
            char c = s[b];
            s[b] = s[f];
            s[f] = c;
            b++;
            f--;
        }
    }
}