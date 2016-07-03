namespace LeetCode
{
    /* https://leetcode.com/problems/intersection-of-two-linked-lists/
     * 160. Intersection of Two Linked Lists
        Total Accepted: 80268 Total Submissions: 263677 Difficulty: Easy
        Write a program to find the node at which the intersection of two singly linked lists begins.


        For example, the following two linked lists:

        A:          a1 → a2
                           ↘
                             c1 → c2 → c3
                           ↗            
        B:     b1 → b2 → b3
        begin to intersect at node c1.


        Notes:

        If the two linked lists have no intersection at all, return null.
        The linked lists must retain their original structure after the function returns.
        You may assume there are no cycles anywhere in the entire linked structure.
        Your code should preferably run in O(n) time and use only O(1) memory.
     */

    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    internal class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA==null || headB==null)
            {
                return null;
            }
            ListNode a = headA, b = headB;
            int countA = 0, countB = 0;
            while(a!=null)
            {
                countA++;
                a = a.next;
            }
            while(b!=null)
            {
                countB++;
                b = b.next;
            }
            a = headA;
            b = headB;
            if(countA>countB)
            {
                while(countA-countB>0)
                {
                    countA--;
                    a = a.next;
                }
            }
            else
            {
                while(countB-countA>0)
                {
                    countB--;
                    b = b.next;
                }
            }
            while(a!=null && b!=null)
            {
                if(a.val==b.val)
                {
                    return a;
                }
                a = a.next;
                b = b.next;
            }
            return null;
        }
    }
}
