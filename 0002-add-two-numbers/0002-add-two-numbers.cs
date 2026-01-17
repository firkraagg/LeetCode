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
    private ListNode ln = new();
    private ListNode current;
    private int remainder = 0;
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        current = ln;
        Add(l1, l2);
        return ln.next;
    }

    public void Add(ListNode l1, ListNode l2) {
        if (l1 == null && l2 == null) {
            if (remainder > 0) {
                current.next = new ListNode(remainder);
            }

            return;
        };
        int number1 = (l1 != null) ? l1.val : 0;
        int number2 = (l2 != null) ? l2.val : 0;
        current.next = new ListNode(number1 + number2 + remainder);
        remainder = current.next.val / 10;
        current.next.val %= 10;

        current = current.next;
        Add(l1?.next, l2?.next);
    }
}