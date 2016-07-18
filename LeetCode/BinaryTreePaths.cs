using System.Collections.Generic;

namespace LeetCode
{
    /* https://leetcode.com/problems/binary-tree-paths/
     * 257. Binary Tree Paths
        Total Accepted: 55625
        Total Submissions: 184247
        Difficulty: Easy
        Given a binary tree, return all root-to-leaf paths.

        For example, given the following binary tree:

           1
         /   \
        2     3
         \
          5
        All root-to-leaf paths are:

        ["1->2->5", "1->3"]
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
    internal class BinaryTreePaths
    {
        public IList<string> GetAllBinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();
            if(root==null)
            {
                return list;
            }
            List<string> pathList = new List<string>();
            Helper(root, list, pathList);
            return list;
        }

        private void Helper(TreeNode node,IList<string> resultList,List<string> pathlist)
        {
            pathlist.Add(node.val.ToString());
            if(node.left!=null)
            {
                Helper(node.left, resultList, pathlist);
            }
            if(node.right!=null)
            {
                Helper(node.right, resultList, pathlist);
            }
            string s = string.Join("->", pathlist);
            resultList.Add(s);
            pathlist.RemoveAt(pathlist.Count - 1);
        }
    }
}
