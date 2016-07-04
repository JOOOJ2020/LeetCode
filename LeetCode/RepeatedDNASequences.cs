using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/repeated-dna-sequences/
     * 187. Repeated DNA Sequences
        Total Accepted: 47406 Total Submissions: 179455 Difficulty: Medium
        All DNA is composed of a series of nucleotides abbreviated as A, C, G, and T, for example: "ACGAATTCCG". 
        When studying DNA, it is sometimes useful to identify repeated sequences within the DNA.
        Write a function to find all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.

        For example,

        Given s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT",

        Return:
        ["AAAAACCCCC", "CCCCCAAAAA"].
     */
    internal class RepeatedDNASequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            IList<string> list = new List<string>();
            if(string.IsNullOrEmpty(s) || s.Length<11)
            {
                return list;
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i <= s.Length-10; i++)
            {
                string temp = s.Substring(i, 10);
                if(dict.ContainsKey(temp))
                {
                    if (dict[temp] == 1)
                    { list.Add(temp); }
                    dict[temp]++;
                }
                else
                {
                    dict.Add(temp, 1);
                }
            }
            return list;
        }

        public IList<string> FindRepeatedDnaSequences2(string s)
        {
            var list = new List<string>();
            if (s.Length < 10) { return list; }
            HashSet<int> once = new HashSet<int>();
            HashSet<int> twice = new HashSet<int>();
            var arr = new int[26];
            arr['A' - 'A'] = 0;
            arr['C' - 'A'] = 1;
            arr['G' - 'A'] = 2;
            arr['T' - 'A'] = 3;
            int enc = 0;
            for (int i = 0; i < 9; ++i)
            {
                enc <<= 2;
                enc |= arr[s[i] - 'A'];
            }
            for (int j = 9; j < s.Length; ++j)
            {
                enc <<= 2;
                enc &= 0xfffff;
                enc |= arr[s[j] - 'A'];
                if (!once.Add(enc) && twice.Add(enc))
                    list.Add(s.Substring(j - 9, 10));
            }
            return list;

        }
    }
}
