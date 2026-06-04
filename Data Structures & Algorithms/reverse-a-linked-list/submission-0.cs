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
 
public class Solution 
{
    public ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode next = curr.next; // save next node
            curr.next = prev;          // reverse pointer
            prev = curr;               // move prev forward
            curr = next;               // move curr forward
        }

        return prev;
    }
}
