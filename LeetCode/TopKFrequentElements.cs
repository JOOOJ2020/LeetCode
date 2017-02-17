using System;
using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/top-k-frequent-elements/
     * 347. Top K Frequent Elements
        Description  Submission  Solutions  Add to List
        Total Accepted: 50086
        Total Submissions: 107850
        Difficulty: Medium
        Contributors: Admin
        Given a non-empty array of integers, return the k most frequent elements.

        For example,
        Given [1,1,1,2,2,3] and k = 2, return [1,2].

        Note: 
        You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
        Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
     */
    internal class TopKFrequentElements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0)
            {
                return new List<int>();
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            List<int>[] array = new List<int>[nums.Length + 1];

            foreach (var item in dict)
            {
                if (array[item.Value] == null)
                {
                    array[item.Value] = new List<int>();
                }
                array[item.Value].Add(item.Key);
            }

            List<int> result = new List<int>(k);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (k > 0)
                {
                    if (array[i] != null)
                    {
                        int rest = Math.Min(array[i].Count, k);
                        for (int j = 0; j < rest; j++)
                        {
                            result.Add(array[i][j]);
                            k--;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
