public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        if(s.Length > t.Length)
            return false;
        int sp = 0, tp = 0;
        
        while(tp < t.Length)
        {
            if(sp >= s.Length)
                return true;
            if(s[sp] == t[tp])
                sp++;
            tp++;
        }
        if(sp >= s.Length)
            return true;

        return false;
    }
}