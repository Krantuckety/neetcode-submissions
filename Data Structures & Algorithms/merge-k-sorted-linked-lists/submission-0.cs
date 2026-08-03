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
    public ListNode MergeKLists(ListNode[] lists) 
    {
        PriorityQueue<int, int> pq = new();
        if(lists.Length == 0)
            return null;

        for(int i = 0; i < lists.Length; i++)
        {
            ListNode ln = lists[i];
            while(ln != null)
            {
                pq.Enqueue(ln.val, ln.val);
                ln = ln.next;
            }
        }

        ListNode head = new ListNode(pq.Dequeue(), null);
        ListNode pointer = head;
        while(pq.Count > 0)
        {
            ListNode temp = new ListNode(pq.Dequeue(), null);
            pointer.next = temp;
            pointer = pointer.next;
        }

        return head;
    }
}
