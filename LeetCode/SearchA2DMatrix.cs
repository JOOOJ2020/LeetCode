namespace LeetCode
{
    /* https://leetcode.com/problems/search-a-2d-matrix/
     * 74. Search a 2D Matrix
        Total Accepted: 88200
        Total Submissions: 254677
        Difficulty: Medium
        Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.
        For example,

        Consider the following matrix:

        [
          [1,   3,  5,  7],
          [10, 11, 16, 20],
          [23, 30, 34, 50]
        ]
        Given target = 3, return true.
     */
    internal class SearchA2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }
            int col = matrix.GetLength(1) - 1, row = 0;
            while (col >= 0 && row < matrix.GetLength(0))
            {
                if (target == matrix[row, col])
                {
                    return true;
                }
                else if (target > matrix[row, col])
                {
                    row++;
                }
                else
                {
                    col--;
                }
            }
            return false;
        }
    }
}
