/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 *
 * https://leetcode-cn.com/problems/binary-tree-inorder-traversal/description/
 *
 * algorithms
 * Easy (75.60%)
 * Likes:    1255
 * Dislikes: 0
 * Total Accepted:    673.6K
 * Total Submissions: 890.5K
 * Testcase Example:  '[1,null,2,3]'
 *
 * 给定一个二叉树的根节点 root ，返回它的 中序 遍历。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：root = [1,null,2,3]
 * 输出：[1,3,2]
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
 * 输出：[2,1]
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
 * 进阶: 递归算法很简单，你可以通过迭代算法完成吗？
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
    // public IList<int> InorderTraversal(TreeNode root)
    // {
    //     List<int> res = new List<int>();
    //     accessTree(root, res);
    //     return res;
    // }

    // private void accessTree(TreeNode root, List<int> res)
    // {
    //     if (root == null) return;
    //     accessTree(root.left, res);
    //     res.Add(root.val);
    //     accessTree(root.right, res);
    // }

    // With Loop
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stk = new Stack<TreeNode>();
        while (root != null || stk.Count != 0)
        {

            while (root != null)
            {
                stk.Push(root);
                root = root.left;
            }

            root = stk.Pop();
            res.Add(root.val);
            root = root.right;
        }
        return res;
    }
}
// @lc code=end

