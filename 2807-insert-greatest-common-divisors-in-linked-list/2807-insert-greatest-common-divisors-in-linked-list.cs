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
            int gcd = CalculateGcd(currNode.val, nextNode.val);
            currNode.next = new ListNode(gcd, nextNode);
            currNode = nextNode;
            nextNode = currNode.next;
        }

        return head;
    }

    private int CalculateGcd(int num1, int num2) {
        int smallerNum = Math.Min(num1, num2);
        for (int i = smallerNum; i > 0; i--) {
            if (num1 % i == 0 && num2 % i == 0) {
                return i;
            }
        }

        return 1;
    }
}