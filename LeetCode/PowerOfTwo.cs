namespace LeetCode
{
    /* https://leetcode.com/problems/power-of-two/
     * 231. Power of Two
        Total Accepted: 84672
        Total Submissions: 224665
        Difficulty: Easy
        Given an integer, write a function to determine if it is a power of two.
     */
    internal class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if(n==0 || n==int.MinValue)
            {
                return false;
            }
            return (n & (n - 1)) == 0;
        }
    }
}
