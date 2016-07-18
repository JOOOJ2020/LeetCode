using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/ugly-number-ii/
     * 264. Ugly Number II
        Total Accepted: 35532
        Total Submissions: 120845
        Difficulty: Medium
        Write a program to find the n-th ugly number.

        Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10 ugly numbers.

        Note that 1 is typically treated as an ugly number.

        Hint:

        The naive approach is to call isUgly for every number until you reach the nth one. Most numbers are not ugly. Try to focus your effort on generating only the ugly ones.
        An ugly number must be multiplied by either 2, 3, or 5 from a smaller ugly number.
        The key is how to maintain the order of the ugly numbers. Try a similar approach of merging from three sorted lists: L1, L2, and L3.
        Assume you have Uk, the kth ugly number. Then Uk+1 must be Min(L1 * 2, L2 * 3, L3 * 5).
     */
    internal class UglyNumberII
    {
        public int NthUglyNumber(int n)
        {
            if(n==1)
            {
                return n;
            }
            int[] uglys = new int[n + 1];
            uglys[0] = 0;
            uglys[1] = 1;
            int p2 = 1, p3 = 1, p5 = 1,index=2;
            while(index < n+1)
            {
                int n2 = uglys[p2] * 2,n3 = uglys[p3] * 3, n5 = uglys[p5] * 5;
                uglys[index] = Math.Min(n2, Math.Min(n3, n5));
                if(uglys[index] == n2)
                {
                    p2++;
                }
                if (uglys[index] == n3)
                {
                    p3++;
                }
                if (uglys[index] == n5)
                {
                    p5++;
                }                
                index++;
            }
            return uglys[n];
        }
    }
}
