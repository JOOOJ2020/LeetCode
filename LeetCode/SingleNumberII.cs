using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/single-number-ii/
     * 137. Single Number II 
        Total Accepted: 87716 Total Submissions: 229174 Difficulty: Medium
        Given an array of integers, every element appears three times except for one. Find that single one.

        Note:
        Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
     */
    internal class SingleNumberII
    {
        public int Solution(int[] nums)
        {
            if(nums==null)
            {
                throw new ArgumentNullException();
            }
            int[] bits = new int[32];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    int temp = (int)Math.Pow(2, j);
                    if((nums[i]&temp)==temp)
                    {
                        bits[31 - j] += 1;
                    }
                }
            }
            for (int i = 0; i < 32; i++)
            {
                if(bits[i] !=0 )
                {
                    bits[i] = bits[i]%3;
                }
            }
            string str = string.Join("", bits);
            return Convert.ToInt32(str, 2);

        }
    }
}
