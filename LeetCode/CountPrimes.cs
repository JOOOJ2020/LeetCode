using System.Linq;

namespace LeetCode
{
    /* https://leetcode.com/problems/count-primes/
     * 204. Count Primes
        Total Accepted: 70301
        Total Submissions: 280569
        Difficulty: Easy
        Description:
        Count the number of prime numbers less than a non-negative number, n.
     */
    internal class CountPrimes
    {
        public int Solution(int n)
        {
            if(n<2)
            {
                return 0;
            }
            // We start off with a table of n numbers. Let's look at the first number, 
            //2. We know all multiples of 2 must not be primes, so we mark them off as non-primes. Then we look at the next number, 
            //3. Similarly, all multiples of 3 such as 3 × 2 = 6, 3 × 3 = 9, ... must not be primes, so we mark them off as well. 
            //Now we look at the next number, 4, which was already marked off. What does this tell you? Should you mark off all multiples of 4 as well?
            int[] array = new int[n];
            for (int i = 2; i*i < n; i++)
            {
                if(array[i]==1)
                {
                    continue;
                }
                for (int j = i; j*i < n; j++) 
                {
                    array[j*i] = 1;
                }
            }
            return array.Where(t => t == 0).Count() - 2;
        }
    }
}
