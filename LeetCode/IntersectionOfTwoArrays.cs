using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /* https://leetcode.com/problems/intersection-of-two-arrays/
     * 349. Intersection of Two Arrays
        Total Accepted: 31610
        Total Submissions: 71047
        Difficulty: Easy
        Given two arrays, write a function to compute their intersection.

        Example:
        Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

        Note:
        Each element in the result must be unique.
        The result can be in any order.
     */
    internal class IntersectionOfTwoArrays
    {
        /// <summary>
        /// using hashset to store one of array
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersection1(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return new int[0];
            }
            HashSet<int> nums1Set = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1Set.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums1Set.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// order two arrays and check one by one. HashSet contains the result.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return new int[0];
            }
            HashSet<int> result = new HashSet<int>();
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
                else if(nums1[i]< nums2[j])
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
    }
}
