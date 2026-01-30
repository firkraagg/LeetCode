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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head.next == null) return head;
        ListNode currNode = head;
        ListNode nextNode = head.next;
        while (nextNode != null) {
            int gcd = currNode.val <= nextNode.val ? currNode.val : nextNode.val;
            for (int i = gcd; i > 0; i--) {
                if (currNode.val % i == 0 && nextNode.val % i == 0) {
                    currNode.next = new ListNode(i, nextNode);
                    currNode = nextNode;
                    nextNode = currNode.next;
                    break;
                }
            }
        }

        return head;
    }
}