/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution 
{
    public Node copyRandomList(Node head) 
    {
        if(head == null)
            return null;
        
        Dictionary<Node, Node> hash = new();
        Node node = head;

        while(node != null)
        {
            hash[node] = new Node(node.val);
            node = node.next;
        }

        foreach(var pair in hash)
        {
            Node n = pair.Key;
            Node copy = pair.Value;
            if(n.next != null)
                copy.next = hash[n.next];
            if(n.random != null)
                copy.random = hash[n.random];
        }

        return hash[head];
    }
}
