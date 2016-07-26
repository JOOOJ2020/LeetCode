using System;
using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/intersection-of-two-arrays-ii/
     * 350. Intersection of Two Arrays II
        Total Accepted: 22102
        Total Submissions: 53035
        Difficulty: Easy
        Given two arrays, write a function to compute their intersection.

        Example:
        Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

        Note:
        Each element in the result should appear as many times as it shows in both arrays.
        The result can be in any order.
        Follow up:
        What if the given array is already sorted? How would you optimize your algorithm?
        What if nums1's size is small compared to nums2's size? Which algorithm is better?
        What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
     */
    internal class IntersectionOfTwoArraysII
    {
        /// <summary>
        /// If two array is already sorted, we could use two point and figure out intersect between two arrays.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersect1(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return new int[0];
            }
            List<int> result = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0, j = 0;
            while(i<nums1.Length && j<nums2.Length)
            {
                if(nums1[i]==nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i]<nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return result.ToArray();
        }
        /// <summary>
        /// If one array is small compare with another one, input the small array into dictionary, then cycle the big one and find the intersect numbers.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>

        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return new int[0];
            }
            List<int> result = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if(dict.ContainsKey(nums1[i]))
                {
                    dict[nums1[i]]++;
                }
                else
                {
                    dict.Add(nums1[i], 1);
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if(dict.ContainsKey(nums2[i]) && dict[nums2[i]]>0)
                {
                    result.Add(nums2[i]);
                    dict[nums2[i]]--;
                }
            }
            return result.ToArray();
        }
    }
}
