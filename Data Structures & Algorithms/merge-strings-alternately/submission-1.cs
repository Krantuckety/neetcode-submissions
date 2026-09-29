public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int minLen = Math.Min(word1.Length, word2.Length);
        StringBuilder sb = new();
        for(int i = 0; i < minLen; i++) {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }

        if(word1.Length > word2.Length) 
            sb.Append(word1, minLen, word1.Length - minLen);
        else if(word1.Length < word2.Length)
            sb.Append(word2, minLen, word2.Length - minLen);

        return sb.ToString();
    }
}