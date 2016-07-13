namespace LeetCode
{
    /* https://leetcode.com/problems/delete-node-in-a-linked-list/
     * 237. Delete Node in a Linked List
        Total Accepted: 91929 Total Submissions: 207818 Difficulty: Easy
        Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.

        Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, the linked list should become 1 -> 2 -> 4 after calling your function.
     */
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            if(node==null)
            {
                return;
            }
            ListNode next = node;
            node.val = next.val;
            node.next = next.next;
        }
    }
}
