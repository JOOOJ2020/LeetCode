namespace LeetCode
{
    /*https://leetcode.com/problems/swap-nodes-in-pairs/
     * 24 Swap Nodes in Pairs 
        Total Accepted: 104603 Total Submissions: 293125 Difficulty: Easy
        Given a linked list, swap every two adjacent nodes and return its head.

        For example,
        Given 1->2->3->4, you should return the list as 2->1->4->3.

        Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
     */
    internal class SwapNodesInPairs
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head, next = cur.next, pre = null;
            ListNode newHead = cur.next;
            while (cur != null && cur.next != null)
            {
                next = cur.next;
                if (pre != null)
                {
                    pre.next = next;
                }
                pre = cur;
                cur.next = next.next;
                next.next = cur;                
                cur = cur.next;
            }
            return newHead;
        }
    }
}
