using System.Collections;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int curLength = LengthOfLongestSubstringFrom(s, i);
            if (curLength > longestLength)
            {
                longestLength = curLength;
            }
        }
        return longestLength;
    }

    private int LengthOfLongestSubstringFrom(string s, int i)
    {
        HashSet<int> seen = new HashSet<int>();
        int length = 0;

        while(i < s.Length)
        {
            if (seen.Contains(s[i]))
            {
                break;
            }

            seen.Add(s[i]);
            length++;
            i++;
        }
        return length;
    }
}