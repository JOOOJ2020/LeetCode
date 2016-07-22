namespace LeetCode
{
    /* https://leetcode.com/problems/range-sum-query-immutable/
     * 303. Range Sum Query - Immutable
        Total Accepted: 37004
        Total Submissions: 146195
        Difficulty: Easy
        Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

        Example:
        Given nums = [-2, 0, 3, -5, 2, -1]

        sumRange(0, 2) -> 1
        sumRange(2, 5) -> -1
        sumRange(0, 5) -> -3
        Note:
        You may assume that the array does not change.
        There are many calls to sumRange function.
     */
    internal class RangeSumQueryImmutable
    {
        private int[] array = null;
        public RangeSumQueryImmutable(int[] nums)
        {
            array = new int[nums.Length];
            array = new int[nums.Length];
            if (array.Length != 0)
            {
                array[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    array[i] = array[i - 1] + nums[i];
                }
            }            
        }

        public int SumRange(int i, int j)
        {
            if(i==0)
            {
                return array[j];
            }
            return array[j] - array[i - 1];
        }
    }
}
