namespace LeetCode
{
    /* https://leetcode.com/problems/reverse-string/
     * 344. Reverse String
        Total Accepted: 58791
        Total Submissions: 100171
        Difficulty: Easy
        Write a function that takes a string as input and returns the string reversed.

        Example:
        Given s = "hello", return "olleh".
     */
    internal class ReverseString
    {
        public string Solution(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }
            char[] c = s.ToCharArray();
            int i = 0, j = c.Length - 1;
            while(i<j)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
                i++;
                j--;
            }
            return new string(c);
        }
    }
}
