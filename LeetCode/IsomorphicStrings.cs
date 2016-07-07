using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/isomorphic-strings/
     * 205. Isomorphic Strings
        Total Accepted: 63582
        Total Submissions: 208385
        Difficulty: Easy
        Given two strings s and t, determine if they are isomorphic.

        Two strings are isomorphic if the characters in s can be replaced to get t.

        All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

        For example,
        Given "egg", "add", return true.

        Given "foo", "bar", return false.

        Given "paper", "title", return true.

        Note:
        You may assume both s and t have the same length.
     */
    internal class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            {
                return true;
            }
            else if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return false;
            }
            char[] arrayS = s.ToCharArray();
            char[] arrayT = t.ToCharArray();
            Array.Sort(arrayS, arrayT);
            for (int i = 0; i < arrayS.Length-1; i++)
            {
                if(arrayS[i]==arrayS[i+1] && arrayT[i]!=arrayT[i+1])
                {
                    return false;
                }
            }
            Array.Sort(arrayT, arrayS);
            for (int i = 0; i < arrayT.Length-1; i++)
            {
                if((arrayT[i]==arrayT[i+1]) ^ (arrayS[i]==arrayS[i+1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
