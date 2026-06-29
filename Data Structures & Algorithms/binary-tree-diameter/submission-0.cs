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
    int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) 
    {
        DepthFirst(root);
        return diameter;
    }

    public int DepthFirst(TreeNode node)
    {
        if(node == null)
            return 0;
        
        diameter = Math.Max(diameter, (DepthFirst(node.left) + DepthFirst(node.right)));

        return (1 + Math.Max(DepthFirst(node.left), DepthFirst(node.right)));
    }
}
