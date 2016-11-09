using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /* https://leetcode.com/problems/sort-characters-by-frequency/
     * 451. Sort Characters By Frequency   QuestionEditorial Solution 
        Given a string, sort it in decreasing order based on the frequency of characters.

        Example 1:

        Input:
        "tree"

        Output:
        "eert"

        Explanation:
        'e' appears twice while 'r' and 't' both appear once.
        So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
        Example 2:

        Input:
        "cccaaa"

        Output:
        "cccaaa"

        Explanation:
        Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
        Note that "cacaca" is incorrect, as the same characters must be together.
        Example 3:

        Input:
        "Aabb"

        Output:
        "bbAa"

        Explanation:
        "bbaA" is also a valid answer, but "Aabb" is incorrect.
        Note that 'A' and 'a' are treated as two different characters.
     */
    public class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] array = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            SortedDictionary<int, List<char>> sDict = new SortedDictionary<int, List<char>>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    dict[array[i]]++;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }
            var result = dict.OrderByDescending(t => t.Value);
            StringBuilder sb = new StringBuilder(sDict.Count());
            foreach (var item in result)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    sb.Append(item.Key);
                }
            }
            return sb.ToString();
            
        }
    }
}
