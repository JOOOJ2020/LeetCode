using System.Collections.Generic;

namespace LeetCode
{
    /*
     * 94. Binary Tree Inorder Traversal 
        Total Accepted: 131407 Total Submissions: 324964 Difficulty: Medium
        Given a binary tree, return the inorder traversal of its nodes' values.

        For example:
        Given binary tree [1,null,2,3],
           1
            \
             2
            /
           3
        return [1,3,2].

        Note: Recursive solution is trivial, could you do it iteratively?
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
    internal class BinaryTreeInorderTraversal
    {
        public IList<int> Solution(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null || (root.left == null && root.right == null))
            {
                return list;
            }
            Helper(root, list);
            return list;
        }

        private void Helper(TreeNode node, IList<int> list)
        {
            if (node.left != null)
            {
                Helper(node.left, list);
            }
            list.Add(node.val);
            if (node.right != null)
            {
                Helper(node.right, list);
            }
        }

        // without recursive solution
        public IList<int> Solution2(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
            {
                return list;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            while (stack.Count > 0 || node != null)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    node = stack.Pop();
                    list.Add(node.val);
                    node = node.right;
                }

            }
            return list;
        }
    }
}
