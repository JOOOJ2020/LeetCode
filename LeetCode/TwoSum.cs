using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     * https://leetcode.com/problems/two-sum/
     * 1. Two Sum 
        Total Accepted: 248229 Total Submissions: 1019064 Difficulty: Easy
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution.

        Example:
        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].
        UPDATE (2016/2/13):
        The return format had been changed to zero-based indices. Please read the above updated description carefully.
     */
    internal class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }
            int i = 0, j = nums.Length - 1;
            int[] indexArray = nums.Select((item, index) => index).ToArray();
            Array.Sort(nums,indexArray);
            while (i <= j)
            {
                if (nums[i] + nums[j] == target)
                {
                    break;
                }
                else if (nums[i] + nums[j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return new int[] { indexArray[i], indexArray[j] };
        }
    }
}
