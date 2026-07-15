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
    public bool HasCycle(ListNode head) 
    {
        ListNode node = head;
        HashSet<ListNode> hashTable = new HashSet<ListNode>();
        while (node != null)
        {
            if(hashTable.Contains(node))
            {
                return true;
            }
            hashTable.Add(node);
            node = node.next;
        }

        return false;
    }
}
