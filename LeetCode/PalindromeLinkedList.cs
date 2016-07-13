namespace LeetCode
{
    /* https://leetcode.com/problems/palindrome-linked-list/
     * 234. Palindrome Linked List
        Total Accepted: 55827 Total Submissions: 190528 Difficulty: Easy
        Given a singly linked list, determine if it is a palindrome.
     */
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    internal class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if(head==null || head.next==null)
            {
                return true;
            }
            ListNode tail = head, mid = head;
            bool flag = true;
            while(tail.next!=null)
            {
                if(!flag)
                {
                    mid = mid.next;
                }
                tail = tail.next;
                flag = !flag;
            }
            ListNode pre = null,cur=mid,next=cur.next;
            while(cur!=null)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;                
                cur = next;
            }
            tail = pre;
            while(head!=null)
            {
                if(head.val!=tail.val)
                {
                    return false;
                }
                head = head.next;
                tail = tail.next;
            }
            return true;
        }
    }
}
