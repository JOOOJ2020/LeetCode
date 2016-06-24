using System;
using System.Collections.Generic;

namespace LeetCode
{
    /*https://leetcode.com/problems/3sum/
     * 	15.3 sum
	Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
    Find all unique triplets in the array which gives the sum of zero.
	Note:
		• Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ≤ b ≤ c)
		• The solution set must not contain duplicate triplets.
	    For example, given array S = {-1 0 1 2 -1 -4},
	A solution set is:
    (-1, 0, 1)
    (-1, -1, 2)
     */
    internal class ThreeSum
    {
        public IList<IList<int>> Solution(int[] nums)
        {
            List<IList<int>> resultList = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return resultList;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                //if duplicate, then continue
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int target = 0 - nums[i];
                int x = i + 1, y = nums.Length - 1;
                while (x < y)
                {
                    if (nums[x] + nums[y] == target)
                    {
                        List<int> list = new List<int>() { nums[i], nums[x], nums[y] };
                        resultList.Add(list);
                        x++;
                        y--;
                        // if duplicate,then continue
                        while (x < y && nums[x] == nums[x - 1]) { x++; }
                        while (x < y && nums[y] == nums[y + 1]) { y--; }
                    }
                    else if (nums[x] + nums[y] < target)
                    {
                        x++;
                    }
                    else
                    {
                        y--;
                    }

                }

            }
            return resultList;
        }
    }
}
