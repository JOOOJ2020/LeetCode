namespace LeetCode
{
    /* https://leetcode.com/problems/invert-binary-tree/
     * 226. Invert Binary Tree
        Total Accepted: 102726
        Total Submissions: 219605
        Difficulty: Easy
        Invert a binary tree.

             4
           /   \
          2     7
         / \   / \
        1   3 6   9
        to
             4
           /   \
          7     2
         / \   / \
        9   6 3   1
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
    internal class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            Helper(root);
            return root;
        }

        private void Helper(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.left != null || node.right != null)
            {
                TreeNode temp = node.left;
                node.left = node.right;
                node.right = temp;
            }
            Helper(node.left);
            Helper(node.right);
        }
    }
}
