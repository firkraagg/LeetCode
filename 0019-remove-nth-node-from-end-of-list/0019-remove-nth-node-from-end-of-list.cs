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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = GetSize(head);
        ListNode start = head;
        ListNode parent = null;
        ListNode son = null;
        for (int i = 0; i < size - n; i++) {
            parent = head;
            head = head.next;
            son = head.next;
        }

        if (parent is not null) {
            parent.next = son;
        }
        else {
            start = head.next;
        }

        head.next = null;
        return start;
    }

    private int GetSize(ListNode head) {
        if (head is null) return 0;

        int size = 1;
        while(head.next is not null) {
            head = head.next;
            size++;
        }

        return size;
    }
}