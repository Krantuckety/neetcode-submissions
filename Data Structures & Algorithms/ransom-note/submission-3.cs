public class Solution 
{
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        Dictionary<char, int> ransDict  = new();
        Dictionary<char, int> magDict   = new();

        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(ransDict.ContainsKey(ransomNote[i]))
                ransDict[ransomNote[i]]++;
            else
                ransDict.Add(ransomNote[i], 1);
        }

        for(int i = 0; i < magazine.Length; i++)
        {
            if(magDict.ContainsKey(magazine[i]))
                magDict[magazine[i]]++;
            else
                magDict.Add(magazine[i], 1);
        }

        foreach(KeyValuePair<char, int> pair in ransDict)
        {
            if(!magDict.ContainsKey(pair.Key) || pair.Value > magDict[pair.Key])
                return false;
        }

        return true;
    }
}