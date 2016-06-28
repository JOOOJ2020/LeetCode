namespace LeetCode
{
    /* https://leetcode.com/problems/linked-list-cycle/
     * 141. Linked List Cycle
        Total Accepted: 113844 Total Submissions: 311611 Difficulty: Easy
        Given a linked list, determine if it has a cycle in it.

        Follow up:
        Can you solve it without using extra space?
     */

    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) {
    *         val = x;
    *         next = null;
    *     }
    * }
    */
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode node1 = head;
            ListNode node2 = head.next;
            while (node2 != null)
            {
                if (node1 == node2)
                {
                    return true;
                }
                node1 = node1.next;
                node2 = node2.next;
                if (node2 != null)
                {
                    node2 = node2.next;
                }
            }
            return false;
        }
    }
}
