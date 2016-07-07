using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /* https://leetcode.com/problems/contains-duplicate-ii/
     * 219. Contains Duplicate II
        Total Accepted: 65428
        Total Submissions: 214634
        Difficulty: Easy
        Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] 
        and the difference between i and j is at most k.
     */
    internal class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if(nums==null || nums.Length < 2  || k<=0)
            {
                return false;
            }
            int[] indexs = new int[nums.Length];
            // Initialize indexs array, every item is index. indexs = {0,1,2,.....}
            indexs = indexs.Select((t, i) => i).ToArray();
            Array.Sort(nums, indexs);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i]==nums[i+1])
                {
                    if(indexs[i+1]-indexs[i] <= k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ContainsNearbyDuplicate2(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2 || k <= 0)
            {
                return false;
            }
            // dict contains nums item and index
            Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    if(i-dict[nums[i]] <= k)
                    {
                        return true;
                    }
                    else 
                    {
                        // if the distance is more than k, so the value of dict[nums[i]] need be replaced to current index. 
                        // Because the distance between next index and dict[nums[i]] is more than current distance, update dict[nums[i]] which means update index.
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return false;
        }
    }
}
