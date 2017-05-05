using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/k-diff-pairs-in-an-array/#/description
     * 532. K-diff Pairs in an Array Add to List
        DescriptionHintsSubmissionsSolutions
        Total Accepted: 11400
        Total Submissions: 41288
        Difficulty: Easy
        Contributors:
        murali.kf370
        Given an array of integers and an integer k, you need to find the number of unique k-diff pairs in the array. Here a k-diff pair is defined as an integer pair (i, j), where i and j are both numbers in the array and their absolute difference is k.

        Example 1:
        Input: [3, 1, 4, 1, 5], k = 2
        Output: 2
        Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
        Although we have two 1s in the input, we should only return the number of unique pairs.
        Example 2:
        Input:[1, 2, 3, 4, 5], k = 1
        Output: 4
        Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and (4, 5).
        Example 3:
        Input: [1, 3, 1, 5, 4], k = 0
        Output: 1
        Explanation: There is one 0-diff pair in the array, (1, 1).
        Note:
        The pairs (i, j) and (j, i) count as the same pair.
        The length of the array won't exceed 10,000.
        All the integers in the given input belong to the range: [-1e7, 1e7].
     */
    internal class K_diffPairsInAnArray
    {
        public int FindPairs(int[] nums, int k)
        {
            //return FindNoSpace(nums, k);
            //return FindNeedSpace(nums, k);
        }

        // time O(nlog), space O(1)
        private int FindNoSpace(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
            {
                return 0;
            }
            int sum = 0;
            int i = 0;
            Array.Sort(nums);
            while (i < nums.Length - 1)
            {
                while ((i < nums.Length - 1) && (nums[i] == nums[i + 1]))
                {
                    i++;
                }
                if (i > 0 && nums[i] == nums[i - 1] && k == 0)
                {
                    sum++;
                }
                else
                {
                    if (find(nums, i + 1, nums.Length - 1, nums[i] + k))
                    {
                        sum++;
                    }
                }
                i++;
            }
            return sum;
        }

        private bool find(int[] nums, int start, int end, int target)
        {
            int i = start, j = end;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }
                else if (nums[mid] > target)
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }
            return false;

        }

        // time O(n), space O(n)
        private int FindNeedSpace(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
            {
                return 0;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (k == 0)
                {
                    if (dict[nums[i]] > 1)
                    {
                        sum++;
                        dict[nums[i]] = -1;
                    }
                }
                else if (dict[nums[i]] != -1)
                {
                    if ((dict.ContainsKey(nums[i] + k) && dict[nums[i] + k] != -1))
                    {
                        sum++;
                        dict[nums[i]] = -1;
                    }
                    if (dict.ContainsKey(nums[i] - k) && dict[nums[i] - k] != -1)
                    {
                        sum++;
                        dict[nums[i]] = -1;
                    }
                }
            }

            return sum;
        }
    }
}
