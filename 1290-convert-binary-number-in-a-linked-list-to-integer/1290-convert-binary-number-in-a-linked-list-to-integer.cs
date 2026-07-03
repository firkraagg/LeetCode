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
    public int GetDecimalValue(ListNode head) {
        int size = GetSize(head);
        if (size == 1 && head.val == 1) return 1;
        if (size == 1 && head.val == 0) return 0;

        int power = size - 1;
        int value = 0;
        for (int i = 0; i < size; i++) {
            var num = head.val == 1 ? 2 : 0;
            if (num > 0) {
                value += Convert.ToInt32(Math.Pow(num, power));
            }

            head = head.next;
            power--;
        }

        return value;
    }

    private int GetSize(ListNode head) {
        int size = 1;
        while (head.next is not null) {
            head = head.next;
            size++;
        }

        return size;
    }
}