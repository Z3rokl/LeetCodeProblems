public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 1)
            return 0;

        int startIndex = 0, endIndex = 0;
        int maxSubstringLength = 0;
        var letters = new HashSet<char>();
        while(endIndex < s.Length)
        {
            if (letters.Contains(s[endIndex]))
            {
                maxSubstringLength = maxSubstringLength <= letters.Count ?      letters.Count : maxSubstringLength;
                letters.Remove(s[startIndex]);
                startIndex++;
            }
            else
            {
                letters.Add(s[endIndex]);
                endIndex++;     
            }

        }
        return maxSubstringLength < letters.Count ? letters.Count : maxSubstringLength;
    }
}