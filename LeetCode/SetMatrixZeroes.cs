using System.Linq;

namespace LeetCode
{
    /* https://leetcode.com/problems/set-matrix-zeroes/
     * 73. Set Matrix Zeroes
        Total Accepted: 73687
        Total Submissions: 215436
        Difficulty: Medium
        Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.

        click to show follow up.

        Follow up:
        Did you use extra space?
        A straight forward solution using O(mn) space is probably a bad idea.
        A simple improvement uses O(m + n) space, but still not the best solution.
        Could you devise a constant space solution?
     */
    internal class SetMatrixZeroes
    {
        public void SetZeroes1(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }
            int[] rows = new int[matrix.GetLength(0)];
            int[] cols = new int[matrix.GetLength(1)];
            rows = rows.Select((x, y) => y = 1).ToArray();
            cols = cols.Select((x, y) => y = 1).ToArray();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = 0;
                        cols[j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < cols.Length; j++)
                {
                    if ((rows[i] & cols[j]) == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// ------------------>
        /// -            ^   ^
        /// -            -   -
        /// -            -   -
        /// -            -   -
        /// -            -   -
        /// - ------------   -
        /// V ----------------
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes2(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }
            bool col0 = false;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                if(matrix[i,0]==0)
                {
                    col0 = true;
                }
                for (int j = 1; j < cols; j++)
                {
                    if(matrix[i,j]==0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }
            for (int i = rows-1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 1; j--)
                {
                    if(matrix[i,0]==0 || matrix[0,j]==0)
                    {
                        matrix[i, j] = 0;
                    }
                }
                if(col0)
                {
                    matrix[i, 0] = 0;
                }
            }
        }
    }
}
