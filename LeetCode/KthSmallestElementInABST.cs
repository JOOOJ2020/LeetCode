using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/kth-smallest-element-in-a-bst/
     * 230. Kth Smallest Element in a BST
        Total Accepted: 54422
        Total Submissions: 139305
        Difficulty: Medium
        Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

        Note: 
        You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

        Follow up:
        What if the BST is modified (insert/delete operations) often and you need to find the kth smallest frequently? How would you optimize the kthSmallest routine?

        Hint:

        Try to utilize the property of a BST.
        What if you could modify the BST node's structure?
        The optimal runtime complexity is O(height of BST).
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
    internal class KthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if(root==null)
            {
                throw new ArgumentNullException();
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(stack.Count>0 || root!=null)
            {                
                if(root!=null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    TreeNode node = stack.Pop();
                    k--;
                    root = node.right;
                    if (k == 0)
                    {
                        return node.val;
                    }
                }
                
            }
            return root.val;
        }
    }
}
