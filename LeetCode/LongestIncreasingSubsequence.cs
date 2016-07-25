namespace LeetCode
{
    /* https://leetcode.com/problems/longest-increasing-subsequence/
     * 300. Longest Increasing Subsequence
        Total Accepted: 37431
        Total Submissions: 105417
        Difficulty: Medium
        Given an unsorted array of integers, find the length of longest increasing subsequence.

        For example,
        Given [10, 9, 2, 5, 3, 7, 101, 18],
        The longest increasing subsequence is [2, 3, 7, 101], therefore the length is 4. Note that there may be more than one LIS combination, it is only necessary for you to return the length.

        Your algorithm should run in O(n2) complexity.

        Follow up: Could you improve it to O(n log n) time complexity?
     */
    internal class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if(nums==null || nums.Length==0)
            {
                return 0;
            }
            int[] array = new int[nums.Length];
            int max = nums[0], len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]>=max)
                {
                    array[len] = nums[i];
                    len++;
                    max = nums[i];
                }
                else
                {
                    int pos = FindPosition(nums, 0, len - 1, nums[i]);
                    array[pos] = nums[i];
                    max = array[len - 1];
                }
            }
            return len;
        }

        private int FindPosition(int[] nums,int start,int end,int target)
        {
            while(start<=end)
            {
                int mid = start + (end - start) / 2;
                if(target<=nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
