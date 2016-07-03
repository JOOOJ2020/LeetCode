namespace LeetCode
{
    /* https://leetcode.com/problems/insertion-sort-list/
     * 147. Insertion Sort List
        Total Accepted: 74853 Total Submissions: 249258 Difficulty: Medium
        Sort a linked list using insertion sort.
     */
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class InsertionSortList
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head, pre = null, next = cur.next;
            while (cur != null)
            {
                next = cur.next;
                if (pre == null || pre.val <= cur.val)
                {
                    pre = cur;
                    cur = next;

                }
                else
                {
                    ListNode node = head, spre = null;
                    while (node != null)
                    {
                        if (node.val <= cur.val)
                        {
                            spre = node;
                            node = node.next;
                        }
                        else
                        {
                            if (spre == null)
                            {
                                pre.next = next;
                                cur.next = node;
                                head = cur;
                            }
                            else
                            {
                                spre.next = cur;
                                pre.next = next;
                                cur.next = node;
                                cur = next;
                            }
                            cur = next;

                            break;
                        }

                    }
                }
            }
            return head;
        }
    }
}
