namespace LeetCode
{
    /* https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
     * 106. Construct Binary Tree from Inorder and Postorder Traversal
        Total Accepted: 63759
        Total Submissions: 212170
        Difficulty: Medium
        Given inorder and postorder traversal of a tree, construct the binary tree.

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
    internal class ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if(inorder==null || postorder==null || inorder.Length==0 || postorder.Length==0)
            {
                return null;
            }
            return Build(inorder, postorder, 0, inorder.Length - 1, postorder.Length - 1);
        }

        private TreeNode Build(int[] inorder,int[] postorder,int inorderStart,int inorderEnd,int postStart)
        {
            if(inorderEnd<inorderStart)
            {
                return null;
            }
            TreeNode root = new TreeNode(postorder[postStart]);
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
            root.left = Build(inorder, postorder, inorderStart, index - 1, postStart - (inorderEnd - index) - 1);
            root.right = Build(inorder, postorder, index + 1, inorderEnd, postStart - 1);
            return root;
        }
    }
}
