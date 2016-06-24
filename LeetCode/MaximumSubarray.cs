using System;

namespace LeetCode
{
    /*
     * 53. Maximum Subarray 
        Total Accepted: 118125 Total Submissions: 318942 Difficulty: Medium
        Find the contiguous subarray within an array (containing at least one number) which has the largest sum.

        For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
        the contiguous subarray [4,−1,2,1] has the largest sum = 6.

        click to show more practice.

        More practice:
        If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
     */
    internal class MaximumSubarray
    {
        public int Solution(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return int.MinValue;
            }
            int cur = nums[0], sum = nums[0], max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                cur = nums[i];
                sum = Math.Max(cur, (cur + sum));
                max = Math.Max(Math.Max(cur, sum), max);
            }
            return max;
        }
    }
}
