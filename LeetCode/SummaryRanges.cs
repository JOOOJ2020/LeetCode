using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/summary-ranges/
     * 228. Summary Ranges
        Total Accepted: 50185
        Total Submissions: 198961
        Difficulty: Medium
        Given a sorted integer array without duplicates, return the summary of its ranges.

        For example, given [0,1,2,4,5,7], return ["0->2","4->5","7"].
     */
    internal class SummaryRanges
    {
        public IList<string> Solution(int[] nums)
        {
            IList<string> list = new List<string>();
            if(nums==null || nums.Length==0)
            {
                return list;
            }
            int start = nums[0], end = nums[0];
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i+1]-nums[i]==1)
                {
                    end = nums[i + 1];
                }
                else
                {
                    if (start == end)
                    {
                        list.Add(start.ToString());
                    }
                    else
                    {
                        list.Add(start.ToString() + "->" + end.ToString());
                    }
                    start = nums[i + 1];
                    end = nums[i + 1];
                }
            }
            if(start==end)
            {
                list.Add(start.ToString());
            }
            else
            {
                list.Add(start.ToString() + "->" + end.ToString());
            }
            return list;
        }
    }
}
