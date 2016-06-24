using System;

namespace LeetCode
{
    /*https://leetcode.com/problems/reverse-integer/
     * 7. Reverse Integer 
        Total Accepted: 147137 Total Submissions: 620233 Difficulty: Easy
        Reverse digits of an integer.

        Example1: x = 123, return 321
        Example2: x = -123, return -321

        click to show spoilers.
     */
    internal class ReverseInteger
    {
        public int Solution(int x)
        {
            int result = 0;
            try
            {
                while (x != 0)
                {
                    checked
                    {
                        result = result * 10 + (x % 10);
                    }
                    x = x / 10;

                }
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
