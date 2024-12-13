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
        ListNode mid = head;
        ListNode end = head;

        while (end != null && end.next != null) {
            mid = mid.next;
            end = end.next.next;
        }

        return mid;
    }
}