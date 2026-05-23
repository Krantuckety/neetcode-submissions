public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        // Variable declaration
        int Len = s.Length;
        Dictionary<char, int> sLetters = new Dictionary<char, int>();
        Dictionary<char, int> tLetters = new Dictionary<char, int>();

        // Check if words are even the same length
        if(Len != t.Length)
            return false;
        
        /*  Initialize dictionaries to have zero instances of all lowercase letters
            Only valid characters in s & t are lowercase English letters.    */
        for(char c = 'a'; c <= 'z'; c++)
        {
            sLetters[c] = 0;
            tLetters[c] = 0;
        }

        // Add all characters for string s to sLetters
        for (int i = 0; i < Len; i++)
        {
            char c = s[i];
            sLetters[c] = sLetters[c] + 1;
        }

        // Add all characters for string s to sLetters
        for (int i = 0; i < Len; i++)
        {
            char c = t[i];
            tLetters[c] = tLetters[c] + 1;
        }

        for(char c = 'a'; c <= 'z'; c++)
        {
            if(sLetters[c] != tLetters[c])
                return false;
        }
        return true;
    }
}
