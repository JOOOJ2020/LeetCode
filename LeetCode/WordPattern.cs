using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/word-pattern/
     * 290. Word Pattern
        Total Accepted: 44403
        Total Submissions: 146375
        Difficulty: Easy
        Given a pattern and a string str, find if str follows the same pattern.

        Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.

        Examples:
        pattern = "abba", str = "dog cat cat dog" should return true.
        pattern = "abba", str = "dog cat cat fish" should return false.
        pattern = "aaaa", str = "dog cat cat dog" should return false.
        pattern = "abba", str = "dog dog dog dog" should return false.
        Notes:
        You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
     */
    internal class WordPattern
    {
        public bool Solution(string pattern, string str)
        {
            if(pattern==null && str==null)
            {
                return true;
            }
            else if(string.IsNullOrEmpty(pattern)||string.IsNullOrEmpty(str))
            {
                return false;
            }
            char[] patternArray = pattern.ToCharArray();
            string[] array = str.Split(' ');
            if(patternArray.Length!=array.Length)
            {
                return false;
            }
            Array.Sort(patternArray, array);
            for (int i = 0; i < patternArray.Length-1; i++)
            {
                if((patternArray[i]==patternArray[i+1]) & (array[i]!=array[i+1]))
                {
                    return false;
                }
            }
            Array.Sort(array, patternArray);
            for (int i = 0; i < patternArray.Length - 1; i++)
            {
                if ((patternArray[i] == patternArray[i + 1]) & (array[i] != array[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
