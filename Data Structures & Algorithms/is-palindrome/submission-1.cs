public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        string s2 = s.ToLower();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsLetterOrDigit(s2[i]))
                sb.Append(s2[i]);
        }
        s2 = sb.ToString();

        if(s2.Length == 0)
            return true;

        int b = s2.Length - 1;
        int a = 0;
        while(true)
        {
            if(s2[a] != s2[b])
                return false;
            b--;
            a++;
            if(a >= b)
                return true;
        }
        return true;
    }
}
