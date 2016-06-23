using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     * 2. Add Two Numbers 
        Total Accepted: 152521 Total Submissions: 641791 Difficulty: Medium
        You are given two linked lists representing two non-negative numbers. 
        The digits are stored in reverse order and each of their nodes contain a single digit. 
        Add the two numbers and return it as a linked list.

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
     */

    //Definition for singly-linked list.
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    internal class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode head = null;
            ListNode node = null;
            int flag = 0;
            while (l1 != null && l2 != null)
            {
                int temp = l1.val + l2.val + flag;
                int value = 0;
                if (temp > 9)
                {
                    value = temp - 10;
                    flag = 1;
                }
                else
                {
                    value = temp;
                    flag = 0;
                }
                if (head == null)
                {
                    node = new ListNode(value);
                    head = node;
                }
                else
                {
                    node.next = new ListNode(value);
                    node = node.next;
                }
                l1 = l1.next;
                l2 = l2.next;
               
            }
            while (l1 != null)
            {
                int temp = l1.val + flag;
                int value = 0;
                if (temp > 9)
                {
                    value = temp - 10;
                    flag = 1;
                }
                else
                {
                    value = temp;
                    flag = 0;
                }
                l1 = l1.next;
                node.next = new ListNode(value);
                node = node.next;
            }
            while (l2 != null)
            {
                int temp = l2.val + flag;
                int value = 0;
                if (temp > 9)
                {
                    value = temp - 10;
                    flag = 1;
                }
                else
                {
                    value = temp;
                    flag = 0;
                }
                l2 = l2.next;
                node.next = new ListNode(value);
                node = node.next;
            }
            if(flag==1)
            {
                node.next = new ListNode(flag);
            }
            return head;
        }
    }
}
