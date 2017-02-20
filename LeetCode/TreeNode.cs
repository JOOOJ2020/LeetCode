namespace LeetCode
{
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode GeneBST()
        {
            TreeNode n2 = new TreeNode(2);
            TreeNode n4 = new TreeNode(4);
            TreeNode n3 = new TreeNode(3) { left = n2, right = n4 };
            TreeNode n7 = new TreeNode(7);
            TreeNode n6 = new TreeNode(6) { right = n7 };
            TreeNode n5 = new TreeNode(5) { left = n3, right = n6 };
            return n5;
        }

    }
}
