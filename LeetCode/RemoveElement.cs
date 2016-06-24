﻿namespace LeetCode
{
    /*
     * 27. Remove Element 
        Total Accepted: 125521 Total Submissions: 363148 Difficulty: Easy
        Given an array and a value, remove all instances of that value in place and return the new length.

        Do not allocate extra space for another array, you must do this in place with constant memory.

        The order of elements can be changed. It doesn't matter what you leave beyond the new length.

        Example:
        Given input array nums = [3,2,2,3], val = 3

        Your function should return length = 2, with the first two elements of nums being 2.

        Hint:

        Try two pointers.
        Did you use the property of "the order of elements can be changed"?
        What happens when the elements to remove are rare?
     */
    internal class RemoveElement
    {
        public int Solution(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                while (i <= j && nums[i] != val)
                {
                    i++;
                }
                while (i <= j && nums[j] == val)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
            return j + 1;
        }
    }
}
