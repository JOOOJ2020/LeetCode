namespace LeetCode
{
    /* https://leetcode.com/problems/bitwise-and-of-numbers-range/
     * 201. Bitwise AND of Numbers Range
        Total Accepted: 37407 Total Submissions: 119455 Difficulty: Medium
        Given a range [m, n] where 0 <= m <= n <= 2147483647, return the bitwise AND of all numbers in this range, inclusive.

        For example, given the range [5, 7], you should return 4.
     */
    internal class BitwiseANDofNumbersRange
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            //The idea is very simple:
            //last bit of(odd number & even number) is 0.
            //when m != n, There is at least an odd number and an even number, so the last bit position result is 0.
            //Move m and n rigth a position.
            //Keep doing step 1,2,3 until m equal to n, use a factor to record the iteration time.
            //How many bit need be move from right to left between m and n. For instance, 5=101, 7=111. 101!=111, 10!=11,1==1
            int res = 0;
            while(m!=n)
            {
                res++;
                m = m >> 1;
                n = n >> 1;
            }
            // now m=n, and n or m has move res steps to right, now move res steps back (move left).
            return n << res;
        }
    }
}
