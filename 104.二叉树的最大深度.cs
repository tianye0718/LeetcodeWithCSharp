/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
 *
 * https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/description/
 *
 * algorithms
 * Easy (76.76%)
 * Likes:    1104
 * Dislikes: 0
 * Total Accepted:    605.4K
 * Total Submissions: 788.4K
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * 给定一个二叉树，找出其最大深度。
 * 
 * 二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。
 * 
 * 说明: 叶子节点是指没有子节点的节点。
 * 
 * 示例：
 * 给定二叉树 [3,9,20,null,null,15,7]，
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 返回它的最大深度 3 。
 * 
 */

// @lc code=start
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
    // With Recrusive
    // public int MaxDepth(TreeNode root)
    // {
    //     if (root == null) return 0;
    //     return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    // }

    // With Loop
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int depth = 0;
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            int size = queue.Count;
            while (size > 0)
            {
                root = queue.Dequeue();
                if (root.left != null) queue.Enqueue(root.left);
                if (root.right != null) queue.Enqueue(root.right);
                size--;
            }
            depth++;
        }
        return depth;
    }
}
// @lc code=end

