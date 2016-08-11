namespace LeetCode
{
    /* https://leetcode.com/problems/search-for-a-range/
     * 34. Search for a Range
        Total Accepted: 94098
        Total Submissions: 314969
        Difficulty: Medium
        Given a sorted array of integers, find the starting and ending position of a given target value.

        Your algorithm's runtime complexity must be in the order of O(log n).

        If the target is not found in the array, return [-1, -1].

        For example,
        Given [5, 7, 7, 8, 8, 10] and target value 8,
        return [3, 4].
     */
    internal class SearchForARange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };
            if (nums == null || nums.Length == 0)
            {
                return result;
            }
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if (nums[left] == target)
            {
                result[0] = left;
            }
            else
            {
                return result;
            }

            left = 0;
            right = nums.Length - 1;
            while (left < right)
            {
                //we need mid towards to right, so we use (left+right)/2+1 instead.
                int mid = left + (right - left) / 2 + 1;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid;
                }
            }
            if (nums[right] == target)
            {
                result[1] = right;
            }
            return result;
        }
    }
}
