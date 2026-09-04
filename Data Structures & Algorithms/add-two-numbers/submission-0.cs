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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        int carry = 0;
        ListNode head = new();
        ListNode node = head;

        while(l1 != null || l2 != null)
        {
            int n = carry;
            if(l1 != null)
            {
                n += l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                n += l2.val;
                l2 = l2.next;
            }

            carry = 0;
            if(n >= 10)
            {
                n -= 10;
                carry++;
            }
            node.next = new ListNode(n);
            node = node.next;
        }

        if(carry != 0)
        {
            node.next = new ListNode(carry);
            node = node.next;
        }

        return head.next;;
    }
}
