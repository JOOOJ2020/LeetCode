namespace LeetCode
{
    /*https://leetcode.com/problems/remove-duplicates-from-sorted-list/
     * 83. Remove Duplicates from Sorted List 
        Total Accepted: 123349 Total Submissions: 331379 Difficulty: Easy
        Given a sorted linked list, delete all duplicates such that each element appear only once.

        For example,
        Given 1->1->2, return 1->2.
        Given 1->1->2->3->3, return 1->2->3.
     */
    internal class RemoveDuplicatesfromSortedList
    {
        public ListNode Solution(ListNode head)
        {
            if(head==null || head.next==null)
            {
                return head;
            }
            ListNode node = head,next=null;
            while(node!=null)
            {
                next = node.next;
                if(next !=null && node.val==next.val)
                {
                    node.next = next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }
    }
}
