﻿namespace LeetCode
{
    /* https://leetcode.com/problems/search-a-2d-matrix-ii/
     * 240. Search a 2D Matrix II
        Total Accepted: 42309 Total Submissions: 119326 Difficulty: Medium
        Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

        Integers in each row are sorted in ascending from left to right.
        Integers in each column are sorted in ascending from top to bottom.
        For example,

        Consider the following matrix:

        [
          [1,   4,  7, 11, 15],
          [2,   5,  8, 12, 19],
          [3,   6,  9, 16, 22],
          [10, 13, 14, 17, 24],
          [18, 21, 23, 26, 30]
        ]
        Given target = 5, return true.

        Given target = 20, return false.
     */
    internal class SearchA2DMatrixII
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if(matrix==null)
            {
                return false;
            }
            int row = matrix.GetLength(0)-1;
            int col = matrix.GetLength(1)-1;
            int i = 0;
            while(col>-1 && i<=row)
            {
                if(matrix[i,col]==target)
                {
                    return true;
                }
                else if(matrix[i,col]>target)
                {
                    col--;
                }
                else
                {
                    i++;
                }                
            }
            return false;
        }
    }
}
