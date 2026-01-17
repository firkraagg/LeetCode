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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode currNode = head;
        while(currNode is not null) {
            ListNode childNode = currNode.next;
            while (childNode is not null && currNode.val == childNode.val) {
                childNode = childNode.next;
                currNode.next = childNode;
            }

            currNode = currNode.next;
        }

        return head;
    }
}