/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public List<int> PostorderTraversal(TreeNode root) 
    {
        List<int> result = new();

        DFS(root, result);

        return result;
    }

    public void DFS(TreeNode n, List<int> result)
    {
        if(n == null)
            return;
        
        DFS(n.left, result);
        DFS(n.right, result);
        result.Add(n.val);
    }
}