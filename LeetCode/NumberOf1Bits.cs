namespace LeetCode
{
    /* https://leetcode.com/problems/number-of-1-bits/
     * 191. Number of 1 Bits
        Total Accepted: 99580 Total Submissions: 264891 Difficulty: Easy
        Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).

        For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.
     */
    internal class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while(n>0)
            {
                count++;
                n = n & (n - 1);
            }
            return count;
        }
    }
}
