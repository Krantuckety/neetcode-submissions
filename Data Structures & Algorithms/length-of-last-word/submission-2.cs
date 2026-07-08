public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        int len = 0;
        int i = s.Length - 1;
        bool seenChar = false;
        while (0 <= i)
        {
            if(s[i] == (' '))
            {
                if(seenChar)
                    break;
                else
                    i--;
            }
            else
            {
                len++;
                if(!seenChar)
                    seenChar = true;
                    i--;
            }
        }

        return len;
    }
}