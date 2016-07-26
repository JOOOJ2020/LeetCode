namespace LeetCode
{
    /* https://leetcode.com/problems/integer-break/
     * 343. Integer Break
        Total Accepted: 19802
        Total Submissions: 46527
        Difficulty: Medium
        Given a positive integer n, break it into the sum of at least two positive integers and maximize the product of those integers. Return the maximum product you can get.

        For example, given n = 2, return 1 (2 = 1 + 1); given n = 10, return 36 (10 = 3 + 3 + 4).

        Note: You may assume that n is not less than 2 and not larger than 58.

        Hint:

        There is a simple O(n) solution to this problem.
        You may check the breaking results of n ranging from 7 to 10 to discover the regularities.
     */
    internal class IntegerBreak
    {
        /// <summary>
        /// every n we could break to 2 or 3. When n>4, break num contains 3.
        /// 2=1+1, 3=1+2,4=2+2,5=2+3,6=3+3,7=3+2+2,8=3+3+2,9=3+3+3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Solution(int n)
        {
            if(n==2)
            {
                return 1;
            }
            if(n==3)
            {
                return 2;
            }
            if(n==4)
            {
                return 4;
            }
            int result = 1;
            while(n>4)
            {
                result *= 3;
                n -= 3;
            }
            return result * n;
        }
    }
}
