using System.Collections;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestLength = 0;
        HashSet<char> seen = new HashSet<char>();
        int start = 0;
        int end = 0;

        while (end < s.Length)
        {
            if (seen.Contains(s[end]))
            {
                do
                {
                    seen.Remove(s[start]);
                    start++;
                } while (seen.Contains(s[end]));
            }

            seen.Add(s[end]);
       
            int curLength = end-start+1;
            if (curLength > longestLength)
            {
                longestLength = curLength;
            }

            end++;
        }

        return longestLength;
    }
}