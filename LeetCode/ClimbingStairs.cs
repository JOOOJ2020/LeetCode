namespace LeetCode
{
    /// <summary>
    /// 70. Climbing Stairs
    //Description Submission  Discussion Add to List
    //You are climbing a stair case. It takes n steps to reach to the top.
    //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    //Note: Given n will be a positive integer.
    /// </summary>
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            int n1 = 1, n2 = 2, x = 0;
            while (n > 2)
            {
                x = n1 + n2;
                n1 = n2;
                n2 = x;
                n--;
            }
            return x;
        }
    }
}
