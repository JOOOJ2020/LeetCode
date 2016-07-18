using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/single-number-iii/
     * 260. Single Number III
        Total Accepted: 40537
        Total Submissions: 88791
        Difficulty: Medium
        Given an array of numbers nums, in which exactly two elements appear only once and all the other elements appear exactly twice. Find the two elements that appear only once.

        For example:

        Given nums = [1, 2, 1, 3, 2, 5], return [3, 5].

        Note:
        The order of the result is not important. So in the above example, [5, 3] is also correct.
        Your algorithm should run in linear runtime complexity. Could you implement it using only constant space complexity?
     */
    internal class SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            if(nums==null || nums.Length<2)
            {
                return new int[0];
            }
            int temp = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                temp ^= nums[i];
            }
            int count = 0;
            while(temp!=0)
            {
                
                if((temp&1)==1)
                {
                    break;
                }
                temp = temp >> 1;
                count++;
            }
            int mask = (int)Math.Pow(2, count);
            // int mast=(x&(x-1))^x;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if((nums[i]&mask)==1)
                {
                    result[0] ^= nums[i];
                }
                else
                {
                    result[1]^=nums[i];
                }
            }
            return result;
        }
    }
}
