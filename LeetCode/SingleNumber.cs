using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/single-number/
     * 136. Single Number
        Total Accepted: 135360 Total Submissions: 267600 Difficulty: Medium
        Given an array of integers, every element appears twice except for one. Find that single one.

        Note:
        Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
     */
    internal class SingleNumber
    {
        public int Solution(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException();
            }
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
