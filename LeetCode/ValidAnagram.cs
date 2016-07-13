using System;
using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/valid-anagram/
     * 242. Valid Anagram
        Total Accepted: 93807 Total Submissions: 218608 Difficulty: Easy
        Given two strings s and t, write a function to determine if t is an anagram of s.

        For example,
        s = "anagram", t = "nagaram", return true.
        s = "rat", t = "car", return false.

        Note:
        You may assume the string contains only lowercase alphabets.

        Follow up:
        What if the inputs contain unicode characters? How would you adapt your solution to such case?
     */
    internal class ValidAnagram
    {
        public bool IsAnagram1(string s, string t)
        {
            if(s==null || t==null || s.Length!=t.Length)
            {
                return false;
            }
            if(s==t)
            {
                return true;
            }
            char[] cs = s.ToCharArray();
            char[] ct = t.ToCharArray();
            Array.Sort(cs);
            Array.Sort(ct);
            for (int i = 0; i < cs.Length; i++)
            {
                if(cs[i]!=ct[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnagram2(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length)
            {
                return false;
            }
            if (s == t)
            {
                return true;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i]))
                {
                    return false;
                }
                else
                {
                    dict[t[i]]--;
                }

            }
            foreach (var kvp in dict)
            {
                if (kvp.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
