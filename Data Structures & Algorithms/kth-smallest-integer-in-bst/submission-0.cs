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
    int cnt, output;

    public int KthSmallest(TreeNode root, int k) 
    {
        cnt = 0;
        output = 0;

        DFS(root, k);

        return output;
    }

    public void DFS(TreeNode node, int k)
    {
        if(node == null)
            return;
        
        DFS(node.left, k);
        cnt++;
        if(cnt == k)
            output = node.val;
        DFS(node.right, k);
    }
}
