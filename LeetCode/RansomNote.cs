using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/ransom-note/
     * 383. Ransom Note
        Total Accepted: 5482
        Total Submissions: 12024
        Difficulty: Easy
         Given  an arbitrary  ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom  note can be constructed from the magazines ; otherwise, it will return false.          Each letter in the magazine string can only be used once in your ransom note.

        Note:
        You may assume that both strings contain only lowercase letters.

        canConstruct("a", "b") -> false
        canConstruct("aa", "ab") -> false
        canConstruct("aa", "aab") -> true
     */
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote == null || magazine == null)
            {
                return false;
            }
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }

            char[] noteChar = ransomNote.ToCharArray();
            char[] magazineChar = magazine.ToCharArray();
            Array.Sort(noteChar);
            Array.Sort(magazineChar);
            int n = 0, m = 0;
            while (n < noteChar.Length && m < magazineChar.Length)
            {
                if (noteChar[n] < magazineChar[m])
                {
                    return false;
                }
                else if (noteChar[n] > magazineChar[m])
                {
                    m++;
                }
                else
                {
                    n++; m++;
                }
            }
            if (n == noteChar.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
