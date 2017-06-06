namespace LeetCode
{
    /* https://leetcode.com/problems/longest-palindromic-substring/#/description
     * 5. Longest Palindromic Substring
        Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        Example:
        Input: "babad"
        Output: "bab"
        Note: "aba" is also a valid answer.
        Example:
        Input: "cbbd"
        Output: "bb"
     */
    internal class LongestPalindromeString
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            int maxLen = 1, start = 0;
            int low = 0, high = 0;
            for (int i = 1; i < s.Length; i++)
            {
                low = i - 1;
                //if even, high=i, if odd, high=i-1
                high = i;
                while (low >= 0 && high <= s.Length - 1 && s[low] == s[high])
                {
                    if (high - low + 1 > maxLen)
                    {
                        maxLen = high - low + 1;
                        start = low;
                    }
                    low--;
                    high++;
                }
                low = i - 1;
                high = i + 1;

                while (low >= 0 && high <= s.Length - 1 && s[low] == s[high])
                {
                    if (high - low + 1 > maxLen)
                    {
                        maxLen = high - low + 1;
                        start = low;
                    }
                    low--;
                    high++;
                }
            }
            return s.Substring(start, maxLen);
        }
    }
}
