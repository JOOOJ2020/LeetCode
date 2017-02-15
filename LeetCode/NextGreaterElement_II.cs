using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/next-greater-element-ii/
     * 503. Next Greater Element II
        Description  Submission  Solutions  Add to List
        Total Accepted: 2711
        Total Submissions: 5949
        Difficulty: Medium
        Contributors: love_FDU_llp
        Given a circular array (the next element of the last element is the first element of the array), print the Next Greater Number for every element. The Next Greater Number of a number x is the first greater number to its traversing-order next in the array, which means you could search circularly to find its next greater number. If it doesn't exist, output -1 for this number.

        Example 1:
        Input: [1,2,1]
        Output: [2,-1,2]
        Explanation: The first 1's next greater number is 2; 
        The number 2 can't find next greater number; 
        The second 1's next greater number needs to search circularly, which is also 2.
        Note: The length of given array won't exceed 10000.
     */
    internal class NextGreaterElement_II
    {
        public int[] NextGreaterElements(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }
            int[] result = new int[nums.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < nums.Length * 2; i++)
            {
                //为了将数组扩充为2倍，比如输入的是【1，2，1】，那么扩充后是【1，2，1，1，2，1】，但是不需要重新申请一个2倍的空间，用index跟总数取余就可以了。
                int temp = nums[i % nums.Length];
                while(stack.Count>0 && nums[stack.Peek()]<temp)
                {
                    //思路跟nextGreaterElementI是一样的，只不过这里存储的是index，而不是实际的值。
                    result[stack.Pop()] = temp;
                }
                //当index进入到扩展部分后，那么那一部分的index就不存入stack中
                if(i<nums.Length)
                {
                    stack.Push(i);
                }
            }
            return result;
        }
    }
}
