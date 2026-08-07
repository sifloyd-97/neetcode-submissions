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
    public List<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count>0){
            TreeNode right = null;
            int qlen = q.Count;

            for(int i=q.Count; i>0; i--){
                TreeNode node = q.Dequeue();
                if(node!=null){
                    right = node;
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if(right!=null){
                result.Add(right.val);
            }
        }
        return result;
    }
}
