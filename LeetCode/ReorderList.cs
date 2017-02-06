namespace LeetCode
{
    /* https://leetcode.com/problems/reorder-list/
     * 143. Reorder List
        Description  Submission  Discussion  Add to List
        Total Accepted: 83792
        Total Submissions: 338989
        Difficulty: Medium
        Contributors: Admin
        Given a singly linked list L: L0→L1→…→Ln-1→Ln,
        reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…

        You must do this in-place without altering the nodes' values.

        For example,
        Given {1,2,3,4}, reorder it to {1,4,2,3}.
     */
    internal class ReorderList
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */
        public void ReorderLink(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return;
            }
            ListNode tail = null, mid = null;

            ListNode n1 = head, n2 = head.next, pre = head;
            //find the mid point of this link, 1->2->3->4, 2 is the mid of the link
            while (n2 != null && n2.next != null)
            {
                n1 = n1.next;
                n2 = n2.next.next;
            }
            mid = n1;
            //revert link, 3->4 ==> 4->3
            tail = RevertList(mid.next);
            // split two link, one is 1->2, another is 4->3, if the odd number, one link is 1->2->3, another is 5->4
            mid.next = null;
            n1 = head;
            n2 = tail;
            ListNode next1 = n1.next, next2 = n2.next;
            // merge two links, n1 is 1->2->3, n2 is 5->4
            while (n1 != null && n2 != null)
            {
                n1.next = n2;
                n1 = next1;
                n2.next = next1;
                n2 = next2;
                if (n1 != null)
                    next1 = n1.next;

                if (n2 != null)
                    next2 = n2.next;
            }

        }
        private ListNode RevertList(ListNode head)
        {
            ListNode cur = head, next = head.next, pre = null;
            while (cur != null)
            {
                cur.next = pre;
                pre = cur;
                cur = next;
                if (cur != null)
                {
                    next = cur.next;
                }
            }
            return pre;
        }
    }
}
