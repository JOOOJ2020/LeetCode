namespace LeetCode
{
    /* https://leetcode.com/problems/increasing-triplet-subsequence/
     * 334. Increasing Triplet Subsequence
        Total Accepted: 19011
        Total Submissions: 53732
        Difficulty: Medium
        Given an unsorted array return whether an increasing subsequence of length 3 exists or not in the array.

        Formally the function should:
        Return true if there exists i, j, k 
        such that arr[i] < arr[j] < arr[k] given 0 ≤ i < j < k ≤ n-1 else return false.
        Your algorithm should run in O(n) time complexity and O(1) space complexity.

        Examples:
        Given [1, 2, 3, 4, 5],
        return true.

        Given [5, 4, 3, 2, 1],
        return false.
     */
    internal class IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet1(int[] nums)
        {
            if (nums == null || nums.Length < 3)
            {
                return false;
            }
            int first = nums[0],second=int.MaxValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]<=first)
                {
                    first = nums[i];
                }
                else if(nums[i]<=second)
                {
                    second = nums[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public bool IncreasingTriplet2(int[] nums)
        {
            if(nums==null || nums.Length<3)
            {
                return false;
            }
            int[] array = new int[3];
            int max = nums[0];
            array[0] = nums[0];
            int len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if(max<nums[i])
                {
                    array[len] = nums[i];
                    len++;
                    max = nums[i];
                }
                else
                {
                    int pos = FindPosition(nums, 0, len - 1, nums[i]);
                    array[pos] = nums[i];
                    max = array[len - 1];
                }
            }
            return len==3;
        }
        private int FindPosition(int[] nums,int start,int end,int target)
        {
            while(start<=end)
            {
                int mid = start + (end - start) / 2;
                if(target<=nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
