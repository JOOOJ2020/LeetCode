namespace LeetCode
{
    /* https://leetcode.com/problems/valid-perfect-square/
     * 367. Valid Perfect Square
        Total Accepted: 12629
        Total Submissions: 34517
        Difficulty: Medium
        Given a positive integer num, write a function which returns True if num is a perfect square else False.

        Note: Do not use any built-in library function such as sqrt.

        Example 1:

        Input: 16
        Returns: True
        Example 2:

        Input: 14
        Returns: False
     */
    internal class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
            {
                return true;
            }
            long i = 1, j = num / 2;
            long result = (long)num;
            while (i <= j)
            {
                long mid = i + (j - i) / 2;

                if (mid * mid == result)
                {
                    return true;
                }
                else if (mid * mid < result)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }
            return false;
        }
    }
}
