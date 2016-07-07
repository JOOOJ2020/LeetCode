namespace LeetCode
{
    /* https://leetcode.com/problems/reverse-linked-list/
     * 206. Reverse Linked List
        Total Accepted: 122209
        Total Submissions: 300977
        Difficulty: Easy
        Reverse a singly linked list.
     */

    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    internal class ReverseLinkedList
    {
        public ListNode Solution(ListNode head)
        {
            if(head==null || head.next==null)
            {
                return head;
            }
            ListNode cur = head,pre = null,next=null;
            while(cur!=null)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            return pre;
        }
    }
}
