"""
https://leetcode.com/problems/linked-list-random-node/
382. Linked List Random Node
Total Accepted: 1191
Total Submissions: 2454
Difficulty: Medium
Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen.

Follow up:
What if the linked list is extremely large and its length is unknown to you? Could you solve this efficiently without using extra space?

Example:

// Init a singly linked list [1,2,3].
ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
Solution solution = new Solution(head);

// getRandom() should return either 1, 2, or 3 randomly. Each element should have equal probability of returning.
solution.getRandom();
"""
import random
class Solution(object):
     
    def __init__(self, head):
        """
        @param head The linked list's head. Note that the head is guanranteed to be not null, so it contains at least one node.
        :type head: ListNode
        """
        self.count=0
        self.node=head

    def getRandom(self):
        """
        Returns a random node's value.
        :rtype: int
        """
        num = 1
        temp = self.node.next
        result=self.node.val
        while temp is not None:
            if random.randint(0,num) < 1:
                result=temp.val
            num+=1
            temp=temp.next
        return result