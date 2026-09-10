/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution 
{
    public List<int> Postorder(Node root) 
    {
        List<int> result = new();

        DFS(root, result);

        return result;
    }

    public void DFS(Node n, List<int> result)
    {
        if(n == null)
            return;
        
        for(int i = 0; i < n.children.Count; i++)
        {
            DFS(n.children[i], result);
        }
        result.Add(n.val);
    }
}
