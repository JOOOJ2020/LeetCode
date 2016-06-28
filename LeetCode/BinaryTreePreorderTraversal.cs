using System.Collections.Generic;

namespace LeetCode
{
    /*
     * 144. Binary Tree Preorder Traversal My Submissions QuestionEditorial Solution
     Total Accepted: 127763 Total Submissions: 314561 Difficulty: Medium
    Given a binary tree, return the preorder traversal of its nodes' values.

    For example:
    Given binary tree {1,#,2,3},
       1
        \
         2
        /
       3
    return [1,2,3].

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
    internal class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if(root==null)
            {
                return list;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count>0)
            {
                root = stack.Pop();
                list.Add(root.val);
                if(root.right!=null)
                    stack.Push(root.right);
                if(root.left!=null)
                    stack.Push(root.left);
            }
            return list;
        }
    }
}
