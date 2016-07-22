namespace LeetCode
{
    /*
     * 328. Odd Even Linked List
        Total Accepted: 37999
        Total Submissions: 95704
        Difficulty: Medium
        Given a singly linked list, group all odd nodes together followed by the even nodes. Please note here we are talking about the node number and not the value in the nodes.

        You should try to do it in place. The program should run in O(1) space complexity and O(nodes) time complexity.

        Example:
        Given 1->2->3->4->5->NULL,
        return 1->3->5->2->4->NULL.

        Note:
        The relative order inside both the even and odd groups should remain as it was in the input. 
        The first node is considered odd, the second node even and so on ...
     */
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if(head==null || head.next==null)
            {
                return head;
            }
            ListNode odd = head,evenHead = head.next, even = evenHead;
            while(odd.next!=null && even.next!=null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }
}
