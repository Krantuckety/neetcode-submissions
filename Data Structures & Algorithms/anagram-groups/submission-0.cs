public class Solution 
{
    private Dictionary<char, int> CreateEmptyDictionary()
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        /*  Initialize dictionaries to have zero instances of all lowercase letters
            Only valid characters in s & t are lowercase English letters.    */
        for (char c = 'a'; c <= 'z'; c++)
        {
            dict[c] = 0;
        }
        return dict;
    }

    public string CreateAnagramKey(String s)
    {
        string currentWord = s;
        string anagramKey = "";
        int wordLen = s.Length;
        // Populate dictionary with counts of how many times each letter appears
        Dictionary<char, int> letters = CreateEmptyDictionary();
        for (int j = 0; j < wordLen; j++)
        {
            char c = s[j];
            letters[c] = letters[c] + 1;
        }
        // After letters are counted, create key. 
        for(char c = 'a'; c <= 'z'; c++)
        {
            if(letters[c] != 0)
            {
                string keyComponent = new string(c, letters[c]);
                anagramKey += keyComponent;
            }
        }
        return anagramKey;
    }

    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> output = new List<List<string>>();
        int len = strs.Length;
        List<string> validKeys = new List<string>();
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        
        // Populate dictionary with all of the groups of words that are anagrams.
        for(int i = 0; i < len; i++)
        {
            string key = CreateAnagramKey(strs[i]);
            bool isUniqueKey = true;
            for(int j = 0; j < validKeys.Count; j++)
            {
                if(key == validKeys[j])
                {
                    isUniqueKey = false;
                    break;
                }
            }
            if(isUniqueKey)
            {
                validKeys.Add(key);
                groups[key] = new List<string>();
            }
            groups[key].Add(strs[i]);
        }

        // After words have been sorted into the groups dictionary, format them into the output List
        for(int k = 0; k < validKeys.Count; k++)
        {
            output.Add(groups[validKeys[k]]);
        }
        return output;
    }
}
