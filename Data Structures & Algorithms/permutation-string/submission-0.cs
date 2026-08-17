public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        if(s1.Length > s2.Length)
            return false;
        Dictionary<char, int> s1Hash = new();
        Dictionary<char, int> s2Hash = new();

        for(int i = 0; i < s1.Length; i++)
        {
            char c = s1[i];
            if(s1Hash.ContainsKey(c))
                s1Hash[c]++;
            else
                s1Hash[c] = 1;
        }

        // Populate the initial "Window"
        for(int i = 0; i < s1.Length; i++)
        {
            char c = s2[i];
            if(s2Hash.ContainsKey(c))
                s2Hash[c]++;
            else
                s2Hash[c] = 1;
        }

        // Check initial window
        if(s1Hash.Count == s2Hash.Count &&
           s1Hash.All(pair =>
               s2Hash.TryGetValue(pair.Key, out int value) &&
               value == pair.Value))
        {
            return true;
        }

        // Back Pointer tracking what letter to remove from s2Hash
        int bp = 0;

        // 
        for(int i = s1.Length; i < s2.Length; i++)
        {
            char c = s2[i];
            if(s2Hash.ContainsKey(c))
                s2Hash[c]++;
            else
                s2Hash[c] = 1;

            char bChar = s2[bp];
            if(s2Hash[bChar] >= 2)
                s2Hash[bChar]--;
            else
                s2Hash.Remove(bChar);
            bp++;

            if(s1Hash.Count == s2Hash.Count &&
             s1Hash.All(pair =>
                 s2Hash.TryGetValue(pair.Key, out int value) &&
                 value == pair.Value))
                    return true;
        }

        return false;
    }
}
