using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/path-sum/
     * 112. Path Sum
        Total Accepted: 108906 Total Submissions: 343930 Difficulty: Easy
        Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

        For example:
        Given the below binary tree and sum = 22,
                      5
                     / \
                    4   8
                   /   / \
                  11  13  4
                 /  \      \
                7    2      1
        return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
     */

    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
    */
    internal class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            return Helper(root, sum, 0);
        }

        private bool Helper(TreeNode node, int sum, int lastSum)
        {
            if (node.left == null && node.right == null && node.val == sum - lastSum)
            {
                return true;
            }

            if (node.left != null && Helper(node.left, sum, lastSum + node.val))
            {
                return true;
            }

            if (node.right != null && Helper(node.right, sum, lastSum + node.val))
            {
                return true;
            }

            return false;
        }
    }
}
