namespace LeetCode
{
    /* https://leetcode.com/problems/sqrtx/
     * 69. Sqrt(x)
        Total Accepted: 106308
        Total Submissions: 408313
        Difficulty: Medium
        Implement int sqrt(int x).

        Compute and return the square root of x.
     */
    internal class Sqrt
    {
        public int MySqrt(int x)
        {
            if(x<2)
            {
                return x;
            }
            long i = 0, j = x / 2;
            while(i<=j)
            {
                long mid = i + (j - i) / 2;
                if(mid*mid==x)
                {
                    return (int)mid;
                }
                else if(mid*mid>x)
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }
            return (int)j;
        }
    }
}
