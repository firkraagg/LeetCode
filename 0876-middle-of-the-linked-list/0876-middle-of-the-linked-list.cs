/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode currNode = head;
        ListNode middleNode;
        int numOfNodes = 0;
        while (currNode.next is not null) {
            currNode = currNode.next;
            numOfNodes++;
        }

        int nodesToCenter = numOfNodes % 2 == 0 ? numOfNodes / 2 : numOfNodes / 2 + 1;
        middleNode = head;
        for (int i = 0; i < nodesToCenter; i++) {
            middleNode = middleNode.next;
        } 

        return middleNode;
    }
}