namespace LeetCode
{
    /* https://leetcode.com/problems/valid-palindrome/
     * 125. Valid Palindrome
        Total Accepted: 113790
        Total Submissions: 464268
        Difficulty: Easy
        Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

        For example,
        "A man, a plan, a canal: Panama" is a palindrome.
        "race a car" is not a palindrome.

        Note:
        Have you consider that the string might be empty? This is a good question to ask during an interview.

        For the purpose of this problem, we define empty string as valid palindrome.
     */
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            s = s.ToLower();
            char[] c = s.ToCharArray();
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (IsValidChar(c[i]) && IsValidChar(c[j]))
                {
                    if (c[i] == c[j])
                    { i++; j--; }
                    else
                    { return false; }
                }
                else if (IsValidChar(c[i]) && !IsValidChar(c[j]))
                {
                    j--;
                }
                else if (!IsValidChar(c[i]) && IsValidChar(c[j]))
                {
                    i++;
                }
                else
                {
                    i++; j--;
                }
            }
            return true;
        }

        private bool IsValidChar(char c)
        {
            return c >= 'a' && c <= 'z' || c >= '0' && c <= '9';
        }
    }
}
