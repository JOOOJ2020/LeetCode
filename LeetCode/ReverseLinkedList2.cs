namespace LeetCode
{
    /* https://leetcode.com/problems/reverse-linked-list-ii/
     * 92. Reverse Linked List II 
        Total Accepted: 75351 Total Submissions: 265408 Difficulty: Medium
        Reverse a linked list from position m to n. Do it in-place and in one-pass.

        For example:
        Given 1->2->3->4->5->NULL, m = 2 and n = 4,

        return 1->4->3->2->5->NULL.

        Note:
        Given m, n satisfy the following condition:
        1 ≤ m ≤ n ≤ length of list.
     */

    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class ReverseLinkedList2
    {
        public ListNode Solution(ListNode head, int m, int n)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head, next = cur.next, pre = null, headNode = null, tailNode = null;
            while (cur != null && n > 0)
            {
                if (m > 1)
                {
                    headNode = cur;
                    cur = cur.next;
                    next = cur.next;
                    m--;
                }
                else
                {
                    if (tailNode == null)
                    {
                        tailNode = cur;
                    }
                    cur.next = pre;
                    pre = cur;
                    cur = next;
                    if (next != null)
                    {
                        next = next.next;
                    }
                }
                n--;
            }
            if (headNode != null)
            {
                headNode.next = pre;
            }
            tailNode.next = cur;
            return headNode == null ? pre : head;
        }

        public ListNode Solution2(ListNode head, int m, int n)
        {
            if (head == null || head.next == null || m == n)
            {
                return head;
            }
            ListNode node = head;
            ListNode tail = null;
            ListNode pre = null, cur = head, end = null;
            while (node != null)
            {
                m--;
                n--;
                if (m > 0 && n > 0)
                {
                    pre = cur;
                    cur = cur.next;

                }
                if (n == 0)
                {
                    end = node;
                    tail = node.next;
                    break;
                }
                node = node.next;
            }

            ListNode pre2 = null, next = cur.next, head2 = cur;
            while (cur != end)
            {
                cur.next = pre2;
                pre2 = cur;
                cur = next;
                next = cur.next;
            }
            cur.next = pre2;
            head2.next = tail;
            if (pre != null)
                pre.next = cur;
            else
                head = cur;
            return head;
        }
    }
}
