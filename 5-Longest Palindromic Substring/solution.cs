public class Solution {
    public string LongestPalindrome(string s) {
        int longestLength = 0;
        int longestStart = -1;


        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                int length = j-i+1;
                if (length > longestLength && isSubstringPalindrone(s, i, j))
                {
                    longestLength = length;
                    longestStart = i;
                }
            }
        }
        return s.Substring(longestStart, longestLength);
    }

    private bool isSubstringPalindrone(string s, int start, int end)
    {
        while (end > start)
        {
            if (s[start] != s[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}