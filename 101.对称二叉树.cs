/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
 *
 * https://leetcode-cn.com/problems/symmetric-tree/description/
 *
 * algorithms
 * Easy (56.87%)
 * Likes:    1730
 * Dislikes: 0
 * Total Accepted:    488.5K
 * Total Submissions: 857.5K
 * Testcase Example:  '[1,2,2,3,4,4,3]'
 *
 * 给你一个二叉树的根节点 root ， 检查它是否轴对称。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：root = [1,2,2,3,4,4,3]
 * 输出：true
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：root = [1,2,2,null,3,null,3]
 * 输出：false
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 树中节点数目在范围 [1, 1000] 内
 * -100 <= Node.val <= 100
 * 
 * 
 * 
 * 
 * 进阶：你可以运用递归和迭代两种方法解决这个问题吗？
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
    // With recrusive
    // public bool IsSymmetric(TreeNode root)
    // {
    //     if (root == null || (root.left == null && root.right == null)) return true;
    //     return deepCheck(root.left, root.right);
    // }

    // private bool deepCheck(TreeNode left, TreeNode right)
    // {
    //     if (left == null & right == null) return true;
    //     if (left == null || right == null || left.val != right.val) return false;

    //     return deepCheck(left.left, right.right) && deepCheck(left.right, right.left);
    // }

    // With Loop
    public bool IsSymmetric(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode u = root.left;
        TreeNode v = root.right;

        if (root == null || (u == null && v == null)) return true;

        queue.Enqueue(u);
        queue.Enqueue(v);

        while (queue.Count != 0)
        {
            u = queue.Dequeue();
            v = queue.Dequeue();
            if (u == null && v == null) continue;
            if (u == null || v == null || u.val != v.val) return false;

            queue.Enqueue(u.left);
            queue.Enqueue(v.right);

            queue.Enqueue(u.right);
            queue.Enqueue(v.left);
        }
        return true;
    }
}
// @lc code=end

