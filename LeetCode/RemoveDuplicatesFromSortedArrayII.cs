namespace LeetCode
{
    /* https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
     * 80. Remove Duplicates from Sorted Array II
        Total Accepted: 86256
        Total Submissions: 254417
        Difficulty: Medium
        Follow up for "Remove Duplicates":
        What if duplicates are allowed at most twice?

        For example,
        Given sorted array nums = [1,1,1,2,2,3],

        Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length.
     */
    internal class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums==null || nums.Length==0)
            {
                return 0;
            }
            if(nums.Length<3)
            {
                return nums.Length;
            }
            int index = 1;
            for (int i = 2; i < nums.Length; i++)
            {
                if(nums[i]>nums[index-1])
                {
                    nums[index + 1] = nums[i];
                    index++;
                }
            }
            return index + 1;
        }
    }
}
