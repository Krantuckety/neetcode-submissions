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
public class Solution {
    public List<int> PreorderTraversal(TreeNode root) 
    {
        List<int> result = new();

        DFS(root, result);

        return result;
    }

    public void DFS(TreeNode n, List<int> result)
    {
        if(n == null)
            return;
        
        result.Add(n.val);
        DFS(n.left, result);
        DFS(n.right, result);
    }
}