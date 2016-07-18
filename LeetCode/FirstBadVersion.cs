using System;

namespace LeetCode
{
    /* https://leetcode.com/problems/first-bad-version/
     * 278. First Bad Version
        Total Accepted: 52288
        Total Submissions: 227440
        Difficulty: Easy
        You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

        Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

        You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
     */
    internal class FirstBadVersion
    {
        public int Solution(int n)
        {
            int start = 1, end = n, mid = 0;
            while(start <= end)
            {
                mid = start + (end - start) / 2;
                if(isBadVersion(mid))
                {
                    end = mid-1;
                }
                else
                {
                    start = mid+1;
                }
            } 
            return start;
        }

        private bool isBadVersion(int version)
        {
            throw new NotImplementedException();
        }
    }
}
