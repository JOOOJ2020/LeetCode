namespace LeetCode
{
    /* https://leetcode.com/problems/missing-number/
     * 268. Missing Number
        Total Accepted: 60516
        Total Submissions: 146203
        Difficulty: Medium
        Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

        For example,
        Given nums = [0, 1, 3] return 2.

        Note:
        Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
     */
    internal class MissingNumber
    {
        public int Solution(int[] nums)
        {
            if(nums==null || nums.Length==0)
            {
                return -1;
            }
            int result = 0,last=0;
            // we can consider only one item in the array, others are duplication ones. so index xor with nums[index], and find out which one is missing.
            for (int i = 0; i < nums.Length; i++)
            {
                result = (i^nums[i])^result;
                last++;
            }
            return result^last;
        }
    }
}
