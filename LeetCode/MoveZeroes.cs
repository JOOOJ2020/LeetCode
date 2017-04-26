using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/move-zeroes/
     * 283. Move Zeroes
        Total Accepted: 98939
        Total Submissions: 218021
        Difficulty: Easy
        Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].

        Note:
        You must do this in-place without making a copy of the array.
        Minimize the total number of operations.
     */
    internal class MoveZeroes
    {
        public void Solution(int[] nums)
        {
            if(nums==null)
            {
                throw new ArgumentNullException();
            }
            int start = 0, end = nums.Length - 1;
            while(start < end)
            {
                while(start < nums.Length && nums[start]!=0)
                {
                    start++;
                }
                while(end>-1 && nums[end]==0)
                {
                    end--;
                }
                if(start<end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                }
            }
        }

        /// <summary>
        /// This function is keep items order in the nums if move zero into the tail.
        /// </summary>
        /// <param name="nums"></param>
        public void Solution2(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException();
            }
            int i = 0, j = i+1;
            while(i<=j && j<nums.Length)
            {
                if(nums[i]!=0)
                {
                    i++;
                    j++;
                }
                else if(nums[i]==0 && nums[j]!=0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j++;
                }
                else if(nums[i]==0 && nums[j]==0)
                {
                    j++;
                }
            }
        }
    }
}
