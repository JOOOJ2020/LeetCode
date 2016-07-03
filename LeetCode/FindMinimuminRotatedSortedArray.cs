using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
     * 153. Find Minimum in Rotated Sorted Array
        Total Accepted: 98541 Total Submissions: 267206 Difficulty: Medium
        Suppose a sorted array is rotated at some pivot unknown to you beforehand.

        (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

        Find the minimum element.

        You may assume no duplicate exists in the array.
     */
    internal class FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException();
            }
            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                int mid = i + (j - i) / 2;
                if (nums[mid] >= nums[i] && nums[mid] > nums[j])
                {
                    if (nums[i] < nums[j])
                    {
                        j = mid - 1;
                    }
                    else
                    {
                        i = mid + 1;
                    }
                }
                else if (nums[mid] <= nums[i] && nums[mid] < nums[j])
                {
                    j = mid;
                }
                else if (nums[mid] >= nums[i] && nums[mid] < nums[j])
                {
                    j = mid;
                }
                else if (nums[mid] <= nums[i] && nums[mid] > nums[j])
                {
                    i = mid;
                }
            }
            return nums[i];
        }
    }
}
