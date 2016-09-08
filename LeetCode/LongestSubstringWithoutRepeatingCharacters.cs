using System;
using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/longest-substring-without-repeating-characters/
     * 3. Longest Substring Without Repeating Characters
        Total Accepted: 182327
        Total Submissions: 790053
        Difficulty: Medium
        Given a string, find the length of the longest substring without repeating characters.

        Examples:

        Given "abcabcbb", the answer is "abc", which the length is 3.

        Given "bbbbb", the answer is "b", with the length of 1.

        Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
     */
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int j = 0;
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    /*
                     * s=abba
                     * i       0 1 2 3
                     * j       0 0 2 2
                     * maxLen  0 2 2 2 
                     * 
                     * j:??? how to explain it?
                     */
                    j = Math.Max(dict[s[i]] + 1, j);
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }
                maxLen = Math.Max(maxLen, (i - j + 1));
            }
            return maxLen;
        }
    }
}
