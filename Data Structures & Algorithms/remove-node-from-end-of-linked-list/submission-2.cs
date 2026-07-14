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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy, slow = dummy;
        // Move fast n steps ahead of slow.
        for(int i = 0; i < n; i++)
        {
            fast = fast.next;
            if(fast.next == null)
            {
                return head.next;
            }
        }

        /*  While fast isn't the end, keep moving forward.
            In loop check if its at the end; 
                If so, set next node to the node after itself.
        */
        while(fast != null)
        {
            fast = fast.next;
            ListNode next = slow.next;
            if(fast == null)
            {
                slow.next = next.next;
                return head;
            }
            slow = slow.next;
        }
        return head;
    }
}
