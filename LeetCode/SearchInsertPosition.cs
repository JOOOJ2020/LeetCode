namespace LeetCode
{
    /* https://leetcode.com/problems/search-insert-position/
     * 35. Search Insert Position
        Total Accepted: 120115
        Total Submissions: 314595
        Difficulty: Medium
        Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

        You may assume no duplicates in the array.

        Here are few examples.
        [1,3,5,6], 5 → 2
        [1,3,5,6], 2 → 1
        [1,3,5,6], 7 → 4
        [1,3,5,6], 0 → 0
     */
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if(nums==null || nums.Length==0)
            {
                return 0;
            }
            int i = 0, j = nums.Length - 1;
            while(i<=j)
            {
                int mid = i + (j - i) / 2;
                if(nums[mid]==target)
                {
                    return mid;
                }
                else if(nums[mid]<target)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }
            return i;
        }
    }
}
