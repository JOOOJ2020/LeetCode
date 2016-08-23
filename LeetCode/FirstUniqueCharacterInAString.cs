using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/first-unique-character-in-a-string/
     * 387. First Unique Character in a String
        Total Accepted: 2261
        Total Submissions: 5288
        Difficulty: Easy
        Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

        Examples:

        s = "leetcode"
        return 0.

        s = "loveleetcode",
        return 2.
     */
    internal class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }
            char[] c = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < c.Length; i++)
            {
                if (dict.ContainsKey(c[i]))
                {
                    dict[c[i]] = -1;
                }
                else
                {
                    dict.Add(c[i], i);
                }
            }
            int first = -1;
            foreach (var item in dict)
            {
                if (item.Value != -1)
                {
                    if (first == -1)
                    {
                        first = item.Value;
                    }
                    else if (first > item.Value)
                    {
                        first = item.Value;
                    }
                }
            }
            return first;
        }
    }
}
