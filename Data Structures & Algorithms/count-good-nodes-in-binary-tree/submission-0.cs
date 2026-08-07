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
    public int GoodNodes(TreeNode root) {
        return Dfs(root, root.val);
    }

    private int Dfs(TreeNode node, int maxSoFar){
        if (node == null) return 0;

        int res = (node.val>=maxSoFar)?1:0;
        maxSoFar = Math.Max(maxSoFar, node.val);
        res += Dfs(node.left, maxSoFar);
        res += Dfs(node.right, maxSoFar);
        return res;
    }
}
