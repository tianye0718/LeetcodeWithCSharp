/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 *
 * https://leetcode-cn.com/problems/binary-tree-preorder-traversal/description/
 *
 * algorithms
 * Easy (70.56%)
 * Likes:    725
 * Dislikes: 0
 * Total Accepted:    492.3K
 * Total Submissions: 697K
 * Testcase Example:  '[1,null,2,3]'
 *
 * 给你二叉树的根节点 root ，返回它节点值的 前序 遍历。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：root = [1,null,2,3]
 * 输出：[1,2,3]
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：root = []
 * 输出：[]
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：root = [1]
 * 输出：[1]
 * 
 * 
 * 示例 4：
 * 
 * 
 * 输入：root = [1,2]
 * 输出：[1,2]
 * 
 * 
 * 示例 5：
 * 
 * 
 * 输入：root = [1,null,2]
 * 输出：[1,2]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 树中节点数目在范围 [0, 100] 内
 * -100 
 * 
 * 
 * 
 * 
 * 进阶：递归算法很简单，你可以通过迭代算法完成吗？
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
    // public IList<int> PreorderTraversal(TreeNode root)
    // {
    //     List<int> res = new List<int>();
    //     accessTree(root, res);
    //     return res;
    // }
    // private void accessTree(TreeNode root, List<int> res)
    // {
    //     if (root == null) return;
    //     res.Add(root.val);
    //     accessTree(root.left, res);
    //     accessTree(root.right, res);
    // }

    // With Loop
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stk = new Stack<TreeNode>();
        while (root != null || stk.Count != 0)
        {
            while (root != null)
            {
                res.Add(root.val);
                stk.Push(root);
                root = root.left;
            }
            root = stk.Pop();
            root = root.right;
        }
        return res;
    }
}
// @lc code=end

