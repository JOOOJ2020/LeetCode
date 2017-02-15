using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/find-largest-value-in-each-tree-row/
     * 515. Find Largest Value in Each Tree Row
        Description  Submission  Solutions  Add to List
        Total Accepted: 2355
        Total Submissions: 4549
        Difficulty: Medium
        Contributors: love_FDU_llp
        You need to find the largest value in each row of a binary tree.

        Example:
        Input: 

                  1
                 / \
                3   2
               / \   \  
              5   3   9 

        Output: [1, 3, 9]
     */
    internal class FindLargestValueInEachTreeRow
    {
        /**
        * Definition for a binary tree node.
        * public class TreeNode {
        *     public int val;
        *     public TreeNode left;
        *     public TreeNode right;
        *     public TreeNode(int x) { val = x; }
        * }
        */
        //层次遍历，并且要每一层的输出，在输出时判断是不是最大值。然后将每一层最大的值存入到数组中。
        // depth view, and output in every depth, in each depth we find the max value and store it into List.
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            IList<int> result = new List<int>();
            int max = int.MinValue, rowItemNum = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                rowItemNum--;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                if (node.val > max)
                {
                    max = node.val;
                }
                if (rowItemNum == 0)
                {
                    result.Add(max);
                    rowItemNum = queue.Count;
                    max = int.MinValue;
                }
            }
            return result;
        }
    }
}
