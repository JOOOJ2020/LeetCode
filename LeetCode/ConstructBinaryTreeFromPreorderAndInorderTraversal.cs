namespace LeetCode
{
    /* https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
     * 105. Construct Binary Tree from Preorder and Inorder Traversal
        Total Accepted: 73748
        Total Submissions: 247523
        Difficulty: Medium
        Given preorder and inorder traversal of a tree, construct the binary tree.

        Note:
        You may assume that duplicates do not exist in the tree.
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
    internal class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (inorder == null || preorder == null || inorder.Length == 0 || preorder.Length == 0)
            {
                return null;
            }
            return Build(preorder, inorder, 0, inorder.Length - 1, 0);
        }
        private TreeNode Build(int[] preorder,int[] inorder,int inorderStart,int inorderEnd,int preorderStart)
        {
            if(inorderEnd<inorderStart)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[preorderStart]);
            if(inorderStart==inorderEnd)
            {
                return root;
            }
            int index = 0;
            for (int i = inorderStart; i < inorderEnd+1; i++)
            {
                if(inorder[i]==root.val)
                {
                    index = i;
                    break;
                }
            }
            root.left = Build(preorder, inorder, inorderStart, index - 1, preorderStart + 1);
            root.right = Build(preorder, inorder, index + 1, inorderEnd, preorderStart + (index - inorderStart) + 1);
            return root;
           
        }
    }
}
