namespace LeetCode
{
    /* https://leetcode.com/problems/merge-two-sorted-lists/
     * 21. Merge Two Sorted Lists
        Total Accepted: 140657
        Total Submissions: 387457
        Difficulty: Easy
        Merge two sorted linked lists and return it as a new list. 
        The new list should be made by splicing together the nodes of the first two lists.
     */
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class MergeTwoSortedLists
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            
            ListNode head = null, n1 = l1, n2 = l2;
            if (n1.val > n2.val) { head = n2; n2 = n2.next; }
            else { head = n1; n1 = n1.next; }
            ListNode node = head;
            while (n1 != null && n2 != null)
            {
                if (n1.val > n2.val)
                {
                    node.next = n2;
                    n2 = n2.next;
                }
                else
                {
                    node.next = n1;
                    n1 = n1.next;
                }
                node = node.next;
            }
            if (n1 == null)
            {
                node.next = n2;
            }
            if (n2 == null)
            {
                node.next = n1;
            }
            return head;
        }
    }
}
