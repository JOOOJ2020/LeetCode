using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/majority-element-ii/
     * 229. Majority Element II
        Total Accepted: 32018
        Total Submissions: 121693
        Difficulty: Medium
        Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.

        Hint:

        How many majority elements could it possibly have?
        Do you have a better hint? Suggest it!
     */
    internal class MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> list = new List<int>();
            if(nums==null || nums.Length==0)
            {
                return list;
            }
            int num1 = 0, num2 = 0, count1 = 0, count2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(count1==0)
                {
                    num1 = nums[i];
                    count1++;
                }
                else if(num1==nums[i])
                {
                    count1++;
                }
                else if(count2==0)
                {
                    num2 = nums[i];
                    count2++;
                }
                else if(num2==nums[i])
                {
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }
            if(num1==num2)
            {
                list.Add(num1);
            }
            else
            {
                int x = 0, y = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[i]==num1)
                    {
                        x++;
                    }
                    else if(nums[i]==num2)
                    {
                        y++;
                    }
                }
                if(x>nums.Length/3)
                {
                    list.Add(num1);
                }
                if(y>nums.Length/3)
                {
                    list.Add(num2);
                }
            }
            return list;

        }
    }
}
